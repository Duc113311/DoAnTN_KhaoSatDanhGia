<template>
  <div class="detailQuestion">
    <div class="m-model" :class="{ ishowDetailType: ishowDetailType }">
      <div class="back-dialog"></div>
      <div class="revenue-dialog1 dialog">
        <div class="title-form">
          <label class="title-form-revenue"> <b>Thêm loại câu hỏi</b></label>

          <div class="btn-x">
            <button class="btn-close" @click="btClose()"></button>
          </div>
        </div>
        <el-form :model="questiontype" :rules="rules" ref="questiontype" class="demo-ruleForm">
            <div class="content-form1">
              <div class="content-left-input-l">
                <!-- Tên câu hỏi -->
                <div class="form-group">
                  <label class="input-name" for=""
                    >Tên loại câu hỏi <b style="color: #d40505">*</b></label
                  >
                  <el-form-item prop="questionTypeName">
                        <el-input v-model="questiontype.questionTypeName"></el-input>
                  </el-form-item> 
                </div>
                <!-- Mô tả -->
                <div class="form-group">
                  <label class="input-name" for="">Mô tả</label>
                  <el-form-item prop="describe">
                        <el-input type="textarea" v-model="questiontype.describe"></el-input>
                  </el-form-item>
                </div>
              </div>
            </div>
            <div class="footer-form">
               <el-form-item>
                    <el-button type="primary" class="btn-add" @click="btSave('questiontype')" style="margin-left:10px">Lưu</el-button>
                    <el-button type="primary" class="btn-add" @click="btSaveAdd('questiontype')">Lưu&Thêm</el-button>
                    <el-button @click="resetForm('questiontype')">Reset</el-button>
              </el-form-item>
              
            </div>
        </el-form>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  data() {
    return {
      questiontype: {
        questionTypeName: '',
        describe: '',
      },
      rules:{
         questionTypeName: [
            { required: true, message: 'Làm ơn! Nhập tên loại', trigger: 'blur' },
            { min: 3, message: 'Ký tự tối thiểu 3 ', trigger: 'blur' }
          ],
           describe: [
            { required: true, message: 'Làm ơn! Nhập mô tả', trigger: 'blur' }
          ]
      }
    };
  },
  props: ["ishowDetailType"],
  methods: {
    btClose() {
      this.$emit("btCloseType", true);
    },
    // Hàm lưu
    btSave(formName) {
      const me=this
        this.$refs[formName].validate((valid) => {
          if (valid) {
              axios
        .post("https://localhost:44396/api/QuestionType", me.questiontype)
        .then(() => {
          this.$notify({
            title: "Thành công",
            message: "Thêm loại câu hỏi thành công",
            type: "success",
          });
          this.$emit("btCloseType", true);
        })
        .catch(() => {
          this.$notify.error({
            title: "Thất bại",
            message: "Thêm không thành công",
          });
        });
          } else {
            console.log('error submit!!');
            return false;
          }
        });
      },
    // Hàm thêm và lưu
    btSaveAdd(formName){
       const me=this
        this.$refs[formName].validate((valid) => {
          if (valid) {
              axios
        .post("https://localhost:44396/api/QuestionType", me.questiontype)
        .then(() => {
          this.$notify({
            title: "Thành công",
            message: "Thêm loại câu hỏi thành công",
            type: "success",
          });
          this.$emit("btCloseType", true);
        })
        .catch(() => {
          this.$notify.error({
            title: "Thất bại",
            message: "Thêm không thành công",
          });
        });
          } else {
            console.log('Lỗi');
            return false;
          }
        });
    },
    // Hàm reset from
    resetForm(formName) {
        this.$refs[formName].resetFields();
      }
  },
};
</script>

<style>
.ishowDetailType {
  display: none;
}
.revenue-dialog1 {
  height: 350px;
  width: 450px;
  left: calc(50% - 220px);
  position: absolute;
  border: 1px solid #d1f1ff;
  background: white;
  top: calc(50% - 175px);
  z-index: 3;
  border-radius: 3px;
}
.content-form1 {
  width: 100%;
  height: 224px;
  padding-top: 18px;
  display: flex;
}
.content-left-input-l {
  width: 100%;
  float: left;
  padding-left: 20px;
  padding-right: 24px;
}
</style>
