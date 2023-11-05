const navTemplate = `
    <nav>
        <div class="nav-links">
            <a class="active">Home</a>
        </div>
        <form class="nav-search-div">
            <input type="text" class="nav-search-input" v-model="navLocation" placeholder="Location Search..." @change="updateNavLocation" v-bind:disabled="isNavSearchDisabled" />
            <button type="submit" @click="submitNavLocation"> Search </button>
        </form>
    </nav>
`;

export default {
    props: ['isNavSearchDisabled'],
    emits: ['update-location-nav','submit-nav-location'],
    template: navTemplate,
    methods: {
        updateNavLocation() {
            this.$emit('update-location-nav', this.navLocation);
        },
        submitNavLocation(event) {
            event.preventDefault();
            this.$emit('submit-nav-location', this.navLocation);
        }
    }
};
