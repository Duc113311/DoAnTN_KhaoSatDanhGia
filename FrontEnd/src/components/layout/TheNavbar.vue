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
                <div class="nav-item-text">Quản lý phiếu học sinh</div>
            </router-link>
            <router-link to="/baocao" class="nav-item">
                <div class="nav-item-icon nav-revenue"></div>
                <div class="nav-item-text">Phiếu tạo mới</div>
            </router-link>
            <router-link to="/lophoc" class="nav-item">
                <div class="nav-item-icon nav-bill"></div>
                <div class="nav-item-text">Phiếu giao</div>
             </router-link>
              <router-link to="/tre" class="nav-item">
                <div class="nav-item-icon nav-num-revenue"></div>
                <div class="nav-item-text">Quản lý trẻ</div>
              </router-link>
             <el-col :span="8" class="back" >
            <el-card shadow="hover" >
              <div @click="onback()">
                <i class="el-icon-back"></i> <b>Quay lại</b>
              </div>
            </el-card>
          </el-col>
        </div>

    </div>
    </div>
</template>

<script>
export default {
    name:'Navbar',
    data() {
        return {
            onback(){
                this.$router.push('/generality');
                }
        }
    },
    methods:{
       
    }
}
</script>
<style lang="css" scoped>
.back {
  position: absolute;
  width: 220px;
  padding: 3px;
  bottom: 0;
}
</style>