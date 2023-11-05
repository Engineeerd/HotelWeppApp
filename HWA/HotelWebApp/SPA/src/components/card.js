const cardTemplate = `
<div class="card-container">
    <div class="row">
        <div class="card" v-for="(hotel,id) in hotels" v-bind:key="hotel.id">
            <div class="card-image">
                <img :src="hotel.Image" alt="Card Image" height="180" width="180">
            </div>
            <div class="card-description">
                <p class="hotel-title"> {{ hotel.Name }} </p>
                <p> PRICE: $ {{ hotel.Price.toFixed(2) }} </p>
                <p> ROOMS AVAILABLE: {{ hotel.Available == true ? "Yes" : "No" }}</p>
            </div>
        </div>
    </div>
</div>
`;

export default {
    props: ['hotels'],
    template: cardTemplate,
};