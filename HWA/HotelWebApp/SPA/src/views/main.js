const { createApp, ref } = Vue;

import AppLoader from '/SPA/src/components/loader.js';
import AppNavBar from '/SPA/src/components/navbar.js';
import AppContent from '/SPA/src/views/content.js';
import AppCard from '/SPA/src/components/card.js';

const indexTemplate = `
    <app-loader :isLoading=isLoading />

    <app-nav-bar :isNavSearchDisabled=isNavSearchDisabled @update-location-nav="receiveNavLocationEmit" 
        @submit-nav-location="receiveNavSubmitEmit" />

    <app-content :isSearchDisabled=isSearchDisabled :checkInDate=checkInDate :checkOutDate=checkOutDate :message=message 
        @submit-location="receiveContentSubmitEmit" @update-content-location="receiveLocationEmit" @update-date="recieveChangeDateEmit" />

    <app-card :hotels=hotels />
`;

const app = createApp({
    template: indexTemplate,
    components: {
        AppLoader,
        AppNavBar,
        AppContent,
        AppCard,
    },
    data() {
        return {
            // LOADING PROPS
            isLoading: ref(false),
            // NAV BAR PROPS
            isNavSearchDisabled: ref(false),
            // CONTENT PROPS
            isSearchDisabled: ref(false),
            message: ref(""),
            checkInDate: ref(new Date().toISOString().slice(0, 10)),
            checkOutDate: ref(""),
            // MAIN PROPS
            hotels: ref([]),
            navLocation: ref(""),
            contentLocation: ref(""),
        };
    },
    methods: {
        clearMessage: function () {
            if (this.message == "") { return; }
            setTimeout(() => { this.message = ""; }, 4000);
        },
        getHotels: async function (data) {
            let url = `http://localhost:60472/api/hotels/search`;

            // Make a POST request
            const response = await fetch(url, {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify(data)
            });

            if (response.status == 401) {
                this.message = "PLEASE MAKE SURE YOU HAVE ENTERED A VALID RAPIS API KEY IN THE WEB CONFIG.";
                this.clearMessage();
                return false;
            }
            else {
                const hotelsResponse = await response.json();
                return hotelsResponse;
            }
        },
        getValidationMessage: function (errors) {
            let msg = "";

            switch (errors) {
                case "100":
                    msg = "ERROR: Please Enter A Location.";
                    break;
                case "010":
                    msg = "ERROR: Please Enter A Valid Check In Date.";
                    break;
                case "001":
                    msg = "ERROR: Please Enter A Valid Check Out Date.";
                    break;
                case "110":
                    msg = "ERROR: Please Enter A Location and A Valid Check In Date.";
                    break;
                case "101":
                    msg = "ERROR: Please Enter A Location and A Valid Check Out Date.";
                    break;
                case "011":
                    msg = "ERROR: Please Enter A Valid Check In and Check Out Date.";
                    break;
                case "111":
                    msg = "ERROR: Please Enter A Location, A Valid Check In, and A Valid Check Out Date.";
                    break;
            }
            return msg;
        },
        validation: function (checkIn, checkOut, location) {
            let errors = "";

            errors += (location == null || location == "") ? "1" : "0";
            errors += (checkIn == null || checkIn == "") ? "1" : "0";
            errors += (checkOut == null || checkOut == "") ? "1" : "0";

            if (errors !== "000") {
                this.message = this.getValidationMessage(errors);
                this.clearMessage();
                return false;
            }
            return true;
        },
        submitForm: async function (location) {
            let isValid = this.validation(this.checkInDate, this.checkOutDate, location);
            if (isValid) {
                var data = {
                    Location: location.toLowerCase(),
                    CheckIn: this.checkInDate.toString(),
                    CheckOut: this.checkOutDate.toString(),
                }
                let response = await this.getHotels(data);
                if (response != false) {
                    this.hotels = await this.getHotels(data);
                }
                // HIDE LOADER
                this.isLoading = false;
            } else {
                // HIDE LOADER
                this.isLoading = false;
            }
            console.log(this.hotels);
        },
        receiveNavSubmitEmit: function (location) {
            this.isLoading = true;

            location = ((location == null || location == "") && (this.navLocation == null || this.navLocation == "")) ? this.contentLocation : location;
            this.submitForm(location);
        },
        receiveContentSubmitEmit: function (location) {
            this.isLoading = true;

            location = ((location == null || location == "") && (this.contentLocation == null || this.contentLocation == "")) ? this.navLocation : location;
            this.submitForm(location);
        },
        recieveChangeDateEmit: function (date, dateValue) {
            if (date == "CheckIn") {
                this.checkInDate = dateValue;
            } else {
                this.checkOutDate = dateValue;
            }
        },
        receiveCheckInDateChangeEmit: function (date) {
            this.checkInDate = date;
        },
        receiveCheckOutDateChangeEmit: function (date) {
            this.checkOutDate = date;
        },
        receiveNavLocationEmit: function (location) {
            if (location != null && location != "") {
                this.isSearchDisabled = true;
                this.navLocation = location;
            } else {
                this.isSearchDisabled = false;
                this.navLocation = "";
            }
        },
        receiveLocationEmit: function (location) {
            if (location != null && location != "") {
                this.isNavSearchDisabled = true;
                this.contentLocation = location;
            } else {
                this.isNavSearchDisabled = false;
                this.contentLocation = "";
            }
        },
    }
});

app.mount('#app');
