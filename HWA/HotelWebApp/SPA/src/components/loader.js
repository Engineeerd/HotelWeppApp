const loaderTemplate = `
<div class="loader-background" v-show="isLoading">
    <div class="loader"></div> 
    <br />
    <p> LOADING... </p> 
</div>
`;

export default {
    props: ['isLoading'],
    template: loaderTemplate,
};