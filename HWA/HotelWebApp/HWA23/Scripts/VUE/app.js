import { createApp, ref } from 'vue';

const isNavSearchDisabled = ref();
const isSearchDisabled = ref();
const locationNav = ref("");
const loadingText = ref("");
const checkOutDate = ref();
const checkInDate = ref();
const location = ref("");
const isLoading = ref();
const message = ref("");
const hotels = ref([]);

const app = createApp({
    data() {
        return {
            isNavSearchDisabled: false,
            isSearchDisabled: false,
            isLoading: false,
            loadingText: "Loading...",
            locationNav: "",
            location: "",
            message: "",
            hotels: [],
            checkInDate: new Date().toISOString().slice(0, 10),
            checkOutDate: new Date().toISOString().slice(0, 10)
        }
    },
    methods: {
        clearMessage: function () {
            // Clear Message After A Couple Of Seconds.
            if (this.message == "") { return; }
            setTimeout(() => { this.message = ""; }, 4000);
        },
        getHotels: async function (data) {
            let url =
                `https://localhost:44399/api/hotels/search?location=${data.Location}&checkIn=${data.CheckIn}&checkOut=${data.CheckOut}`;

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
        validation: function () {
            if (this.location === "" && this.locationNav === "") {
                this.message = "ERROR: Please Enter A Location.";
                this.clearMessage();
                return false;
            }
            else if (this.checkInDate.toString() == "" || this.checkOutDate.toString() == "") {
                if (this.checkInDate.toString() == "") { this.message = "ERROR: Please Enter A Valid Check In Date."; }
                else { this.message = "ERROR: Please Enter A Valid Check Out Date."; }
                this.clearMessage();
                return false;
            }
            return true;
        },
        submitData: async function (event) {
            event.preventDefault();

            this.isLoading = true;
            let isValid = this.validation();
            if (isValid) {
                var data = {
                    Location: ((this.location === "") ? this.locationNav : this.location).toLowerCase(),
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
        },
        locationNavSubmit(event) {
            this.submitData(event);
        },
        locationSubmit(event) {
            this.submitData(event);
        },
    },
    mounted() {
        this.$watch('locationNav', function () {
            if (this.locationNav == "") {
                this.isSearchDisabled = false;
            }
            else {
                this.isSearchDisabled = true;
            }
        });
        this.$watch('location', function () {
            if (this.location == "") {
                this.isNavSearchDisabled = false;
            }
            else {
                this.isNavSearchDisabled = true;
            }
        });
    }
});

app.mount('#app');