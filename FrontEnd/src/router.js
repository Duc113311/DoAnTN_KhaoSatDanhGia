import ListQuestion from "./components/views/question/list-question.vue"
import Account from "./components/views/account/list-account.vue"
import Childrent from "./components/views/childrent/list-childernt.vue"
import Evalution from "./components/views/evalution/list-evalution.vue"
import Class from "./components/views/class/list-class.vue"
import DashBoard from "./components/views/dashboard/list-dashboard.vue"
import Repost from "./components/views/repost/list-repost.vue"
import RepostList from "./components/views/repost/list-repostview.vue"
import Login from "./components/Login.vue"
import Generality from "./components/Generality.vue"

const routes = [
    { path: '/', name: 'Login', component: Login },
    { path: '/danhmuc', name: 'DashBoard', component: DashBoard },
    { path: '/generality', name: 'Generality', component: Generality },
    { path: '/cauhoi', component: ListQuestion },
    { path: '/taikhoan', component: Account },
    { path: '/tre', component: Childrent },
    { path: '/phieudanhgia', component: Evalution },
    { path: '/chitietphieu', component: RepostList },
    { path: '/lophoc', component: Class },
    { path: '/baocao', component: Repost },

]
export default routes