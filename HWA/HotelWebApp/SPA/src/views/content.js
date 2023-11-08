const contentTemplate = `
<div class="container">
    <h1 class="title"> HOTEL FINDER </h1>
    <form id="hotel-form">
        <div class="form-group">
            <p>Discover the perfect stay for your next trip with our hotel search service. Whether you're planning a vacation or a business trip, our user-friendly platform allows you to find and book hotels in any city. Simply enter your destination, along with your check-in and check-out dates, and we'll provide you with a curated list of hotels that match your preferences. Our platform helps you compare prices, amenities, and guest reviews, ensuring that you make the best choice for your stay. Start planning your next adventure with our hotel search tool and make your travel experience memorable.</p>
            <center><p class="p-note"> NOTE: MAKER SURE YOU ENTER YOUR OWN RAPIDAPI KEY TO USE THIS PROJECT. </p></center>
            <h5 class="message-text"> {{ message }} </h5>
            <div class="input-content-div">
                <div class="search-div">
                    <input type="text" v-model="location" placeholder="Location Search..." v-bind:disabled="isSearchDisabled" @change="updateLocation" >
                    <small class="form-text text-muted"> Enter The Name of Countries, Cities, Districts, Places, Etc… </small>
                </div>
                <div class="check-in-datepicker">
                    <label for="check-in"> Check In : </label>
                    <input type="date" id="check-in" v-model="checkIn" :min="new Date().toISOString().slice(0, 10)" @change="updateCheckInDate" />
                </div>
                <div class="check-out-datepicker">
                    <label for="check-out"> Check Out : </label>
                    <input type="date" id="check-out" v-model="checkOut" :min="new Date().toISOString().slice(0, 10)" @change="updateCheckOutDate" />
                </div>
            </div>
        </div>
        <div class="search-button-div">
            <button type="submit" class="search-button" @click="submitContentLocation">Submit</button>
        </div>
    </form>
</div>
`;

export default {
    props: ['message', 'isSearchDisabled', 'checkInDate','checkOutDate'],
    emits: ['submit-content-location', 'update-content-location', 'update-date'],
    template: contentTemplate,
    data() {
        return {
            checkIn: this.checkInDate,
            checkOut: this.checkOutDate,
        }
    },
    methods: {
        updateLocation() {
            this.$emit('update-content-location', this.location);
        },
        updateCheckInDate() {
            this.$emit('update-date', "CheckIn", this.checkIn);
        },
        updateCheckOutDate() {
            this.$emit('update-date', "CheckOut", this.checkOut);
        },
        submitContentLocation(event) {
            event.preventDefault();
            this.$emit('submit-location', this.location);
        }
    }
};
