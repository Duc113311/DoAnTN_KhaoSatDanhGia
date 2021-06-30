<template>
  <div class="detailQuestion">
    <div class="m-model" :class="{ showDetail: showDetail }">
      <div class="back-dialog"></div>
      <div class="revenue-dialog dialog">
        <div class="title-form">
          <label :class="{ isAddTitle: isAddTitle }" class="title-form-revenue">
            <b>Thêm thông tin câu hỏi</b></label
          >
          <label :class="{ isUpdateTitle: isUpdateTitle }" class="title-form-revenue">
            <b>Sửa thông tin câu hỏi</b></label
          >

          <div class="btn-x">
            <button class="btn-close" @click="btClose()"></button>
          </div>
        </div>
        <el-form :model="question" :rules="rules" ref="question" class="demo-ruleForm">
          <div class="content-form">
            <div class="content-left-input">
              <!-- Tên câu hỏi -->
              <div class="form-group">
                <label class="input-name" for=""
                  >Tên câu hỏi <b style="color: #d40505">*</b></label
                >
                <el-form-item prop="questionName">
                  <el-input v-model="question.questionName"></el-input>
                </el-form-item>
              </div>

              <!-- Nhóm câu hỏi -->
              <div class="form-group">
                <label for="" class="input-name"
                  >Thuộc nhóm câu hỏi <b style="color: #d40505">*</b>
                </label>
                <div class="group-form">
                  <el-form-item style="width: 300px" prop="questionTypeID">
                    <el-select
                      style="width: 300px"
                      v-model="question.questionTypeID"
                      placeholder="Chọn nhóm câu hỏi"
                    >
                      <el-option
                        v-for="questinType in questionTypes"
                        :key="questinType.questionTypeID"
                        :label="questinType.questionTypeName"
                        :value="questinType.questionTypeID"
                      >
                      </el-option>
                    </el-select>
                  </el-form-item>

                  <div class="btn-sum" @click="btTypeQuestion"></div>
                </div>
              </div>
              <!-- Mô tả -->
              <div class="form-group">
                <label class="input-name" for="">Mô tả </label>
                <el-form-item prop="describe">
                  <el-input type="textarea" v-model="question.describe"></el-input>
                </el-form-item>
              </div>
            </div>
            <div class="content-right-input">
              <div class="option-check">
                <label class="title-check">
                  <input type="checkbox" v-model="question.satisfied" />
                  Hài lòng
                </label>
                <label class="title-check">
                  <input type="checkbox" v-model="question.unsatisfied" />
                  Rất hài lòng
                </label>
                <label class="title-check">
                  <input type="checkbox" v-model="question.verySatisfied" />
                  Không hài lòng
                </label>
                <label class="title-check">
                  <input type="checkbox" v-model="question.veryUnsatisfied" />
                  Rẩt không hài lòng
                </label>
                <label class="title-check">
                  <input type="checkbox" v-model="question.normal" />
                  Bình thường
                </label>
              </div>
            </div>
          </div>
          <div class="footer-form">
            <el-form-item>
              <el-button
                type="primary"
                class="btn-add"
                @click="btSave('question')"
                style="margin-left: 10px"
                >Lưu</el-button
              >
              <el-button type="primary" class="btn-add" @click="btSaveAdd('question')"
                >Lưu&Thêm</el-button
              >
              <el-button @click="resetForm('question')">Reset</el-button>
            </el-form-item>
          </div>
        </el-form>
      </div>
    </div>
    <DetailQuestionType :ishowDetailType="ishowDetailType" @btCloseType="btCloseType" />
  </div>
</template>

<script>
import axios from "axios";
import DetailQuestionType from "../question/detail-question-type.vue";
export default {
  name: "DetailQuestion",
  components: { DetailQuestionType },

  props: [
    "questionTypes",
    "loadData",
    "showDetail",
    "isAddTitle",
    "isUpdateTitle",
    "question",
    "fomatDialog",
  ],

  data() {
    return {
      ishowDetailType: true,
      rules: {
        questionName: [
          { required: true, message: "Làm ơn! Nhập tên câu hỏi", trigger: "blur" },
          { min: 3, message: "Ký tự tối thiểu 3 ", trigger: "blur" },
        ],
        describe: [{ required: true, message: "Làm ơn! Nhập mô tả", trigger: "blur" }],
        questionTypeID: [{ required: true, message: "Please select ", trigger: "blur" }],
      },
    };
  },
  methods: {
    btClose() {
      this.$emit("close", true);
    },
    btCloseType(value) {
      this.ishowDetailType = value;
    },
    valuTite(value) {
      this.showDetail = value;
    },

    btTypeQuestion() {
      this.ishowDetailType = false;
      this.questionTypes = {};
    },

    btSave(formName) {
      const me = this;
      if (this.fomatDialog == 0) {
        this.$refs[formName].validate((valid) => {
          if (valid) {
            axios.put("https://localhost:44396/api/Questions", me.question).then(() => {
              this.$notify({
                title: "Thành công",
                message: "Sửa câu hỏi thành công",
                type: "success",
              });
              this.$emit("loadData");
              this.$emit("close", true);
            });
          } else {
            console.log("error submit!!");
            return false;
          }
        });
      } else {
        this.$refs[formName].validate((valid) => {
          if (valid) {
            axios.post("https://localhost:44396/api/Questions", me.question).then(() => {
              this.$notify({
                title: "Thành công",
                message: "Thêm câu hỏi thành công",
                type: "success",
              });
              this.$emit("loadData");
              this.question = {};
              this.$emit("close", true);
            });
          } else {
            console.log("error submit!!");
            return false;
          }
        });
      }
    },
    // Hàm thêm và lưu
    btSaveAdd(formName) {
      const me = this;
      this.$refs[formName].validate((valid) => {
        if (valid) {
          axios.post("https://localhost:44396/api/Questions", me.question).then(() => {
            this.$notify({
              title: "Thành công",
              message: "Thêm câu hỏi thành công",
              type: "success",
            });
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

<style lang="css" scoped>
.isAddTitle {
  display: none;
}
.isUpdateTitle {
  display: none;
}
</style>
