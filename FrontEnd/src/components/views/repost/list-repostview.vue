<template>
  <div class="dashBoard">
    <div class="main-content">
      <div class="container-fluid">
        <div class="panel panel-headline">
          <div style="margin: auto; width: 770px">
            <div class="btback">
              <el-button type="plain" icon="el-icon-back" circle @click="btback"></el-button>
            </div>
            <div class="btGui">
              <el-button type="primary" plain icon="el-icon-s-promotion" @click="btSave()"
                >Gửi</el-button
              >
            </div>
            <div class="title-c">
              <div class="bor-title"></div>
              <div class="content-title">
                <input
                  placeholder="Nhập tiêu đề"
                  id="evalutionName"
                  v-model="evalutionCard.evalutionName"
                  style="font-size: 20px"
                  class="text"
                  type="text"
                  name=""
                />
                <div id="_warning" class="validate-warning">Không được để trống</div>
                <input
                  placeholder="Mô tả"
                  class="text"
                  v-model="evalutionCard.describe"
                  style="padding: 2px 10px !important"
                  type="text"
                  name=""
                  id=""
                />
              </div>
            </div>
            <div style="overflow: auto; height: 500px; padding-right: 15px">
              <div class="content-num" v-for="(item, index) in valueForm" :key="index">
                <div class="content-title">
                  <div style="width: 100%">
                    <el-select
                      v-model="item.questionId"
                      placeholder="Chọn câu hỏi"
                      style="width: 461px; margin-right: 16px"
                    >
                      <el-option
                        v-for="i in questions"
                        :key="i.questionID"
                        :value="i.questionID"
                        :label="i.questionName"
                      >
                      </el-option>
                    </el-select>
                    <el-select
                      v-model="value"
                      class="txtOption"
                      placeholder="Tự luận"
                      @change="multiplechoice"
                    >
                      <el-option
                        v-for="item in options"
                        :key="item.value"
                        :label="item.label"
                        :value="item.value"
                      >
                      </el-option>
                    </el-select>
                  </div>
                  <!-- Tự luận -->
                  <input
                    v-if="isShow"
                    placeholder="Mô tả"
                    class="text"
                    style="padding: 2px 10px !important;margin-top:6px;"
                    type="text"
                    name=""
                    id=""
                    :disabled="true"
                  />
                  <!-- Trắc nghiệm -->
                  <div
                    v-else
                    style="
                      width: 100%;
                      height: 28px;
                      display: flex;
                      align-items: center;
                      justify-content: center; "
                  >
                    <el-radio-group v-model="radio">
                      <el-radio :label="3">Hài lòng</el-radio>
                      <el-radio :label="6">Không hài lòng</el-radio>
                      <el-radio :label="9">Rất không hài lòng</el-radio>
                      <el-radio :label="9">Rất hài lòng</el-radio>
                      <el-radio :label="9">Bình thường</el-radio>
                    </el-radio-group>
                  </div>
                </div>
                <div
                  style="
                    width: 100%;
                    display: flex;
                    align-items: center;
                    height: 39px;
                    border-top: 1px solid #ccc;
                    margin-top: 13px;
                    justify-content: flex-end;
                  "
                >
                  <el-button-group>
                    <el-button
                      style="padding: 6px"
                      type="primary"
                      @click="removeForm(index)"
                      icon="el-icon-document-copy"
                    ></el-button>
                    <el-button
                      style="padding: 6px; margin-right: 16px"
                      type="primary"
                      @click="removeForm(index)"
                      icon="el-icon-delete"
                    ></el-button>
                  </el-button-group>
                  <div
                    style="
                      display: grid;
                      grid-template-columns: 1fr 1fr;
                      width: 126px;
                      border-left: 1px solid #ccc;
                      padding-left: 9px;
                    "
                  >
                    <label
                      for=""
                      style="font-size: 14px; color: #606266; font-weight: 600"
                      >Bắt buộc</label
                    >
                    <el-switch v-model="value1"> </el-switch>
                  </div>
                </div>
              </div>
              <el-button class="btadd" circle @click="addQuestion()">
                <i class="el-icon-plus"></i>
              </el-button>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  data() {
    return {
      valueForm: [
      
      ],
      isShow: true,
      options: [
        {
          value: "1",
          label: "Trắc nghiệm",
        },
        {
          value: "2",
          label: "Tự luận",
        },
      ],
      questions: [],
      evalution: [],

      evalutionCard:{
        evalutionName:'',
        describe:'',
        listEvalution:''
      }
    };
  },
  computed: {},
  methods: {
    // thêm form câu hỏi
    addQuestion() {

      this.valueForm.push({
        Correct: true,
        questionId:''
      });
    },


    // Xóa form câu hỏi
    removeForm(index) {
      this.valueForm.splice(index, 1);
    },
    // Hiển thị tự tuận
    multiplechoice() {
      console.log("Vao");

     this.isShow = !this.isShow
    },
    essay: function () {
      console.log("hello");
    },
    btback(){
      this.$router.go(-1)
    },
   async btSave() {
      const me=this;
      var arrT=[];
           
      me.valueForm.map(item=>{
       arrT.push(item.questionId);
      })
      me.evalutionCard.listEvalution=arrT.join(',')
        await axios.post("https://localhost:44396/api/EvalutionCard/evalutionCard",this.evalutionCard).then(()=>{
        this.$notify({
          title: 'Thành công',
          message: 'Đã thêm 1 phiếu câu hỏi',
          type: 'success'
        });
        this.valueForm=[]
        this.evalutionCard.evalutionName=''
        this.evalutionCard.describe=''
    })
    },

    async loadDataQuestion() {
      await axios.get("https://localhost:44396/api/Questions").then((res) => {
        this.questions = res.data;
      });
    },

    async loadDataEvalution() {
      await axios.get("https://localhost:44396/api/Evalution").then((res) => {
        this.evalution = res.data;
      });
    },

    /**
     * Không bỏ trống
     */
    onInputRequired: function (elementId) {
      var element = document.getElementById(elementId);
      if (element.value.length <= 0) {
        element.classList.add("required-out");
        document.getElementById(elementId + "_warning").style.display = "block";
        document.getElementsByClassName("validate-warning").style.display = "block";
        return false;
      } else {
        element.classList.remove("required-out");
        document.getElementById(elementId + "_warning").style.display = "none";
        return true;
      }
    },
  },
  created() {
    this.loadDataQuestion();
  },
};
</script>

<style lang="css">
.main-content {
  position: absolute;
  top: 61px;
  left: 221px;
  width: calc(100% - 221px);
  background-color: #eaecef;
  height: calc(100vh - 61px);
  overflow: hidden;
}
.container-fluid {
  padding-right: 19px;
  padding-left: 19px;
  margin-right: auto;
  margin-left: auto;
  height: calc(100vh - 61px);
}
.panel {
  box-shadow: 0 2px 6px rgb(0 0 0 / 8%);
  /* background-color: #fff; */
  margin-bottom: 30px;
  border: 1px solid transparent;
  height: calc(100% - 47px);
  background: #fff;
  margin: 24px 0px;
  overflow: hidden;
  border-radius: 4px;
}
.title-c {
  height: 128px;
  width: 98%;
  overflow: hidden;
  border: 1px solid #ccc;
  border-radius: 13px;
}
.bor-title {
  background-color: rgb(103, 58, 183);
  color: rgba(255, 255, 255, 1);
  border-top-left-radius: 8px;
  border-top-right-radius: 8px;
  height: 10px;
  left: -1px;
  top: -1px;
  width: calc(100% + 2px);
}

.content-title {
  box-sizing: border-box;
  -webkit-box-flex: 1;
  flex-grow: 1;
  outline: none;
  padding: 12px 25px;
  width: 98%;
}
.text {
  width: 99%;
  padding: 10px;
  border: navajowhite;
  border-bottom: 1px solid #ccc;
  margin-bottom: 14px;
}
.text:focus {
  border-color: inherit;
  -webkit-box-shadow: none;
  box-shadow: none;
  outline: none;
}
.content-num {
  border: 1px solid #ccc;
  border-radius: 13px;
  margin-top: 20px;
}
.txtNum {
  width: 65%;
  margin-right: 10px;
  padding: 10px;
  border: navajowhite;
  border-bottom: 1px solid #ccc;
  margin-bottom: 14px;
}
.txtOption {
  width: 30%;
  padding-bottom: 8px;
  padding-top: 8px;
  color: #222;
}
.btThem {
  position: absolute;
  border: 1px solid #ccc;
  top: 32px;
  left: 31px;
  border-radius: 5px;
  background: aliceblue;
}
.btGui {
  position: absolute;
  top: 32px;
  right: 31px;
}
.btback {
  position: absolute;
  top: 32px;
  left: 31px;
}
.isShowB {
  display: none;
}
.isShowA {
  display: none;
}

.btadd {
  position: relative;
  left: 0;
  bottom: 0px;
}

.validate-warning {
  font-family: GoogleSans-Bold;
  font-size: 14px;
  color: red;
  background-color: white;
  position: absolute;
  top: 81px;
  left: 54pc;
  display: none;
}
</style>
