// Create and Initialize Vue App Instance.
let vm = Vue.createApp({});

vm.component('hello', {
    template: `<h1>{{ message }}</h1>`,
    data() {
        return {
            message: 'Hello World!'
        }
    }
});

vm.mount('#app');