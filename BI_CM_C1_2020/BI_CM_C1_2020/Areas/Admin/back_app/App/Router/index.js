import Vue from 'vue';
import VueRouter from 'vue-router';
import Home from '../Views/Home.vue';
import App from '../App.vue'

Vue.config.productionTip = false;
Vue.use(VueRouter);

const routes = [
    {
        path: '/admin',
        component: Home
    }
]

const router = new VueRouter({
    routes,
    mode: 'history'
})

new Vue({
    router,
    render: h => h(App)
}).$mount('#app-root')