<template>
  <div class="generality">
      <div class="manin">
          <div class="from-body">
              <div class="form-title">
                  <div class="title-left">
                      <img src="#" alt="" srcset="">
                       <div class="form-group">
                           <el-select v-model="value" placeholder="Lựa chọn trường">
                            <el-option
                                v-for="item in options"
                                :key="item.value"
                                :label="item.label"
                                :value="item.value">
                                </el-option>
                           </el-select>
                       </div>
                  </div>
                  <div class="title-right">
                      <div class="account">

                      </div>
                  </div>
              </div>
              <div class="form-content">
                  <div class="form-option">
                      <div class="category" @click="btStudent">
                          <div class="logo1"></div>
                          <label class="textLogo" for="">Phụ Huynh</label>
                      </div>
                      <div class="category " @click="btTeacher">
                          <div class="logo2"></div>
                          <label class="textLogo" for="">Giáo Viên</label>
                      </div>
                      <div class="category">
                          <div class="logo3"></div>
                          <label class="textLogo" for="">Quản lý</label>
                      </div>
                  </div>
              </div>
          </div>

      </div>
  </div>
</template>

<script>
import axios from 'axios';
export default {
    name:'Generality',
    data(){
        return{
            options: [{
          value: 'CS1.Trường mầm non Happy Monstessori',
          label: 'CS1.Trường mầm non Happy Monstessori'},  
            ],
            accounts:[]
            }
    },
    methods:{
        btStudent(){
            this.account=JSON.parse(localStorage.getItem('account'));
            console.log(this.account);
            if(this.account.role === 2){
                this.$router.push("/hocsinhrep");
            }else if(this.account.role !== 2){
                    this.$router.push("/hocsinhrep");
            }
        },
        btTeacher(){
            this.account=JSON.parse(localStorage.getItem('account'));
            console.log(this.account);
            if(this.account.role === 1){
                this.$router.push("/danhmuc")
            }else{
                this.$notify.error({
                    title: 'Cảnh báo',
                    message: 'Bạn không có quyền truy cập',
                    type: 'warning'
                    });
                
            }
        },
        
        async LoadAccont(){
             await axios.get("https://localhost:44396/api/Account").then((res) => {
            this.accounts = res.data;
            });
        }
    },
    created(){
        this.LoadAccont();
    }

}
</script>

<style lang=css>
.manin{
     position: absolute;
    top: 0;
    right: 0;
    left: 0;
    bottom: 0;
    background-color: #334068;
}
.form-title{
    height: 53px;
    padding: 20px;
    display: flex;
    align-items: center;
    justify-content: space-between;
}
.form-content{
    width: 100%;
    height: auto;
}
.form-option{
    height: auto;
    text-align: center;
    display: flex;
    justify-content: center;
    padding: 10px 14px;
}
.category{
    width: 150px;
    height: 150px;
    margin-right: 25px;
    overflow: hidden;
    box-shadow: 0 9px 24px 3px #4b2a52;
    border-radius: 9px;
    padding-top: 11px;
}
.category:hover{
    box-shadow: 0 9px 24px 3px #85538f;
    cursor: pointer;
}
.logo1{
    width: 150px;
    height: 104px;
    background-image: url(../assets/img/hocsinh.png);
    background-size: contain;
    background-position: center;
    background-repeat: no-repeat;
}
.logo2{
    width: 150px;
    height: 104px;
    background-image: url(../assets/img/giaovien.png);
    background-size: contain;
    background-position: center;
    background-repeat: no-repeat;

}
.logo3{
    width: 150px;
    height: 104px;
    background-image: url(../assets/img/quanly.png);
    background-size: contain;
    background-position: center;
    background-repeat: no-repeat;

}
.textLogo{
    display: flex;
    justify-content: center;
    align-items: center;
    align-self: center;
    padding: 10px;
    font-size: 17px;
    font-weight: 600;
    color: #fff;
}
</style>