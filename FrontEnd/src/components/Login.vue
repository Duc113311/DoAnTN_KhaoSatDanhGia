<template>
<div class="login">
   <div class="login-modal"></div>
    <div class="login-content">
      <div class="login-content-header">
        <input type="radio" name="login" checked="checked" id="signin" />
        <label for="signin">ĐĂNG NHẬP</label>
        <div class="login-content-body">
        <!-- Model -->
         <el-form :model="ruleForm" status-icon :rules="rules" 
         ref="ruleForm"  class="demo-ruleForm">
         <!-- Nhập tên tài khoản -->
            <el-form-item prop="name">
              <el-input v-model="ruleForm.name"
              placeholder="Nhập tên tài khoản"
              ></el-input>
            </el-form-item>
            <!-- Nhập password -->
           <el-form-item prop="pass">
            <el-input type="password" 
            placeholder="Nhập mật khẩu"
            v-model="ruleForm.pass" autocomplete="off"></el-input>
          </el-form-item>
           
            <el-form-item>
              <el-button type="primary" @click="submitForm('ruleForm')">Đăng nhập</el-button>
              <el-button @click="resetForm('ruleForm')">Load</el-button>
            </el-form-item>
          </el-form>
        </div>

        <input type="radio" name="login" id="signup" />
        <label for="signup">ĐĂNG KÝ</label>
        <div class="login-content-body">
          
          <input
            type="text"
            class="userName"
            placeholder="Nhập tên tài khoản"
            v-model="account.userName"
          />
          <input type="password" class="passWord" placeholder="Nhập mật khẩu" />
          <input
            type="password"
            class="passWord"
            placeholder="Xác nhận lại mật khẩu"
            v-model="account.passWord"
          />
          <div class="signup-footer">
            <button class="btn-xl">HỦY</button>
            <button class="btn-xl accept">ĐĂNG KÝ</button>
          </div>
        </div>
      </div>
      <div class="login-content-footer">
        <a class="link" href="">Quên mật khẩu?</a>
      </div>
    </div>
</div>
</template>

<script>
import axios from "axios";
export default {
     name: "Login",
     data(){
         var validatePass = (rule, value, callback) => {
        if (value === '') {
          callback(new Error('Nhập mật khẩu'));
        } else {
          if (this.ruleForm.checkPass !== '') {
            this.$refs.ruleForm.validateField('checkPass');
          }
          callback();
        }
      };
         return{
           account:{},
          ruleForm: {
          pass:'',
         name: '',
        },
        rules: {
         name: [
            { required: true, message: 'Nhập tên tài khoản', trigger: 'blur' },
            { min: 3,  message: 'Ký tự từ 3', trigger: 'blur' }
          ],
          pass: [
            { validator: validatePass, trigger: 'blur' }
          ],
         
          
        }}
     },
      methods: {


        // Đăng nhập
        submitForm(formName) {
        this.$refs[formName].validate((valid) => {
          if (valid) {
             const param=`userName=${this.ruleForm.name}`+ `&passWord=${this.ruleForm.pass}`
          axios.get("https://localhost:44396/api/Account/filter?"+ param).then((result)=>{
            if(result.data && result){
                this.$router.push("/generality");
                var dataT=JSON.stringify(result.data);
                localStorage.setItem('account',dataT);
                
              }else{
                 this.$notify.error({
                   title: 'Cảnh báo',
                  message: 'Sai tài khoản hoặc mật khẩu',
                  type: 'warning'
                });
              }
          });
          } else {
            console.log('error submit!!');
            return false;
          }
        });
      },
      resetForm(formName) {
        this.$refs[formName].resetFields();
      }
  },
}
</script>

<style >

.login{
    position: fixed;
    top: 0;
    right: 0;
    left: 0;
    bottom: 0;
}

.login-modal{
    position: absolute;
    top: 0;
    right: 0;
    left: 0;
    bottom: 0;
    background-color: #a1dbff;
}

.login-content{
    position: absolute;
    top: calc(50% - 200px);
    left: calc(50% - 200px);
    width: 400px;
    height: 400px;
    background-color: #fff;
    border-radius: 5px;
    box-shadow: 0 1px 3px rgba(0, 0, 0, 0.5);
    overflow: hidden;
}

.login-content-header{
    width: 100%;
    height: calc(100% - 112px);
    display: flex;
    flex-wrap: wrap;
    font-size: 13px;
    padding: 25px 0px;
    align-items: center;
    justify-content: center;
}

.login-content-footer{
    width: 100%;
    height: 60px;
    background-color: #eaeaea;
    text-align: center;
    justify-content: center;
    align-content: center;
    display: grid;
    align-self: center;
}

.login-content input[type="radio"]{
    display: none !important;
}

.login-content label{
    font-size: 15px;
    font-family: 'GoogleSans-Bold';
    color: #bbb;
    height: 20px;
    margin-right: 10px;
}

.login-content .login-content-body{
    width: 100%;
    order: 1;
    display: none;
    height: 100%;
    padding: 35px 50px;
    text-align: center;
}

.login-content input[type='radio']:checked + label + .login-content-body {
    display: block;
}

.login-content input[type="radio"]:checked + label {
    color: #000;
    border-bottom:2px solid #a1dbff;
}

.userName{
    width: 100%;
    height: 40px;
    margin-bottom: 20px;
    outline: none;
    border: none;
    background-color: #eaeaea;
    border-radius: 5px;
    padding-left: 10px;
}

.passWord{
    width: 100%;
    height: 40px;
    margin-bottom: 20px;
    outline: none;
    border: none;
    background-color: #eaeaea;
    border-radius: 5px;
    padding-left: 10px;
}
.accept {
    background-color: #34acf7;
    color: #fff;
}
.signup-footer {
    display: flex;
    justify-content: space-between;
    align-items: center;
}
.btn-xl {
    padding: 10px 30px;
    border: none;
    border-radius: 5px;
    cursor: pointer;
    font-size: 13px;
    font-family: 'GoogleSans-Regular';
    outline: none;
}

</style>