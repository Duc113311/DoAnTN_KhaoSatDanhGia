import Vue from 'vue'
import App from './App.vue'
// Khai báo thư viện router
import VueRouter from 'vue-router'
import routes from './router';

const router = new VueRouter({
    routes
})
Vue.config.productionTip = false

Vue.use(VueRouter)
new Vue({
    router,
    render: h => h(App),
}).$mount('#app')