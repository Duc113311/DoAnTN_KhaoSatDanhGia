<template>
    <div class="MISA-Navbar">
 <div class="m-nvabar">
        <div class="logo-site">
            <div class="logo-box">
                <div class="logo-icon">
                    
                </div>
               <label class="title-logo" for="">MONTESSORI</label>
            </div>
            <div class="bt-category">
                <div class="icon-category"></div>
            </div>
        </div>
        <div class="navbar-content">
             <router-link to="/danhmuc" class="nav-item">
                <div class="nav-item-icon nav-dashboad"></div>
                <div class="nav-item-text">Tổng quan</div>
             </router-link>
           
             <router-link to="/cauhoi" class="nav-item">
                <div class="nav-item-icon nav-num-revenue"></div>
                <div class="nav-item-text">Quản lý câu hỏi</div>
            </router-link> 
            <router-link to="/phieudanhgia" class="nav-item">
                <div class="nav-item-icon nav-revenue"></div>
                <div class="nav-item-text">Quản lý phiếu đánh giá</div>
            </router-link>
            <router-link to="/lophoc" class="nav-item">
                <div class="nav-item-icon nav-bill"></div>
                <div class="nav-item-text">Quản lý lớp học</div>
             </router-link>
              <router-link to="/tre" class="nav-item">
                <div class="nav-item-icon nav-num-revenue"></div>
                <div class="nav-item-text">Quản lý trẻ</div>
              </router-link>
             <router-link to="/baocao" class="nav-item">
                <div class="nav-item-icon nav-repost"></div>
                <div class="nav-item-text">Báo cáo</div>
             </router-link>
             <router-link to="/taikhoan" class="nav-item">
                <div class="nav-item-icon nav-message"></div>
                <div class="nav-item-text">Quản lý tài khoản</div>
             </router-link>
        </div>

    </div>
    </div>
</template>

<script>
export default {
    name:'Navbar',
    data() {
        return {
            
        }
    },
}
</script>