<template>
  <div class="detailQuestion">
    <div class="m-model" :class="{ showDetail: showDetail }">
      <div class="back-dialog"></div>
      <div class="revenue-dialog-chis dialog">
        <div class="title-form">
          <label class="title-form-revenue"> <b>Thêm thông tin trẻ</b></label>

          <div class="btn-x">
            <button class="btn-close" @click="btCloseDong()"></button>
          </div>
        </div>
        <el-form
          :model="ruleForm"
          :rules="rules"
          ref="ruleForm"
          label-width="120px"
          class="demo-ruleForm"
        >
          <div class="content-form-cs">
            <template>
              <!-- Tên  -->
              <el-form-item label="Họ & tên trẻ" prop="childrenName">
                <el-input v-model="ruleForm.childrenName"></el-input>
              </el-form-item>
              <!-- Lớp -->
              <div style="display: grid;grid-template-columns: 1fr 1fr;">
                <el-form-item label="Lớp học" prop="idClassChildren">
                <el-select
                      style="width: 220px"
                      v-model="ruleForm.idClassChildren"
                      placeholder="Chọn lớp"
                    >
                      <el-option
                        v-for="questinType in classChildren"
                        :key="questinType.classID"
                        :label="questinType.className"
                        :value="questinType.classID"
                      >
                      </el-option>
                    </el-select>
              </el-form-item>
               <!-- Tuổi -->
              <el-form-item style="width: 350px;margin-left: 100px;" label="Tuổi">
                <el-input v-model.number="ruleForm.childrenAge"></el-input>
              </el-form-item>
              </div>
              
              <!-- Biệt danh -->
               <div style="display: grid;grid-template-columns: 1fr 1fr;">
              <el-form-item label="Biệt danh" prop="nickName">
               <el-input v-model="ruleForm.nickName"></el-input>
              </el-form-item>
              <el-form-item style="width: 350px;margin-left: 100px;" label="Ngày sinh">
                <el-date-picker
                  type="date"
                  placeholder="Chọn ngày"
                  v-model="ruleForm.dateOfBirth"
                  style="width: 100%"
                ></el-date-picker>
              </el-form-item>
               </div>
              <!-- Sở thích -->
              <el-form-item label="Sở thích" prop="desc">
                <el-input type="textarea" v-model="ruleForm.interest"></el-input>
              </el-form-item>
              <!-- Ngày sinh -->
         
              <!-- Họ tên bố mẹ -->
              <el-form-item label="Tên Bố/Mẹ" prop="parentName">
                <el-input v-model="ruleForm.parentName"></el-input>
              </el-form-item>
              <!-- Số diện thoại -->
              <div style="display: grid;grid-template-columns: 1fr 1fr;">
              <el-form-item label="Số điện thoại" prop="phoneNumber">
                <el-input v-model.number="ruleForm.phoneNumber"></el-input>
              </el-form-item>
              <!-- Email -->
              <el-form-item style="width: 350px;margin-left: 100px;" label="Email" prop="email">
              <el-input v-model="ruleForm.email"></el-input>
              </el-form-item>
              </div>

              <el-form-item style="position: absolute;bottom: 0;right: 0;margin-right: 25px;">
                <el-button type="primary" @click="submitForm('ruleForm')"
                  >Lưu</el-button
                >
                <el-button @click="resetForm('ruleForm')">Reset</el-button>
              </el-form-item>
            </template>
          </div>
        </el-form>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "DetailQuestion",
  
  props: ["showDetail","ruleForm","classChildren","loadGroupData"],

  data() {
    return {
     
      rules: {
        childrenName: [
          { required: true, message: "Nhập họ tên trẻ", trigger: "blur" }
        ],
        idClassChildren: [
          { required: true, message: "Nhập họ tên trẻ", trigger: "blur" }
        ],
        name: [
          { required: true, message: "Nhập họ tên trẻ", trigger: "blur" }
        ],
        parentName: [
          { required: true, message: "Nhập họ tên trẻ", trigger: "blur" }
        ],
         phoneNumber: [
          { required: true, message: "Nhập họ tên trẻ", trigger: "blur" }
        ],
       
        
      },
    };
  },
  methods: {

    btCloseDong(){
      this.$emit("btClose", true);
    },
    submitForm(formName) {
      const me=this
      this.$refs[formName].validate((valid) => {
        if (valid) {
          axios.post("https://localhost:44396/api/Children", me.ruleForm).then(() => {
              this.$notify({
                title: "Thành công",
                message: "Thêm câu hỏi thành công",
                type: "success",
              });
              this.$emit("loadGroupData");
              this.ruleForm = {};
              this.$emit("btClose", true);
            });
        } else {
          console.log("error submit!!");
          return false;
        }
      });
    },
    resetForm(formName) {
      this.$refs[formName].resetFields();
    },
 
  },
};
</script>

<style lang="css">
.showDetail {
  display: none;
}
.revenue-dialog-chis {
  height: 600px;
  width: 840px;
  left: calc(50% - 420px);
  position: absolute;
  border: 1px solid #d1f1ff;
  background: white;
  top: calc(50% - 300px);
  z-index: 3;
  border-radius: 3px;
}
.content-form-cs {

  height: 510px;
  padding: 24px;
}
</style>
