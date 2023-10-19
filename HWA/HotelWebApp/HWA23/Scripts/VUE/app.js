import { createApp, ref } from 'vue';

const isNavSearchDisabled = ref();
const isSearchDisabled = ref();
const isLoading = ref();
const loadingText = ref("");
const checkOutDate = ref();
const checkInDate = ref();
const locationNav = ref("");
const location = ref("");
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
        locationSubmit(event) {
            event.preventDefault();

            this.isLoading = true;
            if (this.location === "" && this.locationNav === "") {
                this.message = "ERROR: Please Enter A Location.";
                this.isLoading = false;
            }
            else if (this.checkInDate.toString() == "" || this.checkOutDate.toString() == "") {
                if (this.checkInDate.toString() == "") { this.message = "ERROR: Please Enter A Valid Check In Date."; }
                else { this.message = "ERROR: Please Enter A Valid Check Out Date."; }
                this.isLoading = false;
            }
            else {
                const getHotels = (async () => {
                    let url = "https://localhost:44399/api/hotels/search?location=" + this.location.toLowerCase() +
                        "&checkIn=" + this.checkInDate.toString() + "&checkOut=" + this.checkOutDate.toString();

                    var data = {
                        Location: this.location.toLowerCase(),
                        CheckIn: this.checkInDate.toString(),
                        CheckOut: this.checkOutDate.toString(),
                    }

                    // Make a POST request
                    const response = await fetch(url, {
                        method: 'POST',
                        headers: { 'Content-Type': 'application/json' },
                        body: JSON.stringify(data)
                    });

                    const hotelsResponse = await response.json();
                    this.hotels = hotelsResponse;
                    //console.log(hotelsResponse);

                    // HIDE LOADER
                    this.isLoading = false;
                })();
            }
        }
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