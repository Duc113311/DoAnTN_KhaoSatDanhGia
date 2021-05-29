import Vue from 'vue'
import App from './App.vue'
// Khai báo thư viện router
import VueRouter from 'vue-router'
import ListQuestion from "./components/views/question/list-question.vue"
import Account from "./components/views/account/list-account.vue"
import Childrent from "./components/views/childrent/list-childernt.vue"
import Evalution from "./components/views/evalution/list-evalution.vue"
import Class from "./components/views/class/list-class.vue"
import DashBoard from "./components/views/dashboard/list-dashboard.vue"
import Repost from "./components/views/repost/list-repost.vue"

const routes = [
    { path: '/', component: DashBoard },
    { path: '/cauhoi', component: ListQuestion },
    { path: '/taikhoan', component: Account },
    { path: '/tre', component: Childrent },
    { path: '/phieudanhgia', component: Evalution },
    { path: '/lophoc', component: Class },
    { path: '/baocao', component: Repost },




]

const router = new VueRouter({
    routes
})
Vue.config.productionTip = false

Vue.use(VueRouter)
new Vue({
    router,
    render: h => h(App),
}).$mount('#app')