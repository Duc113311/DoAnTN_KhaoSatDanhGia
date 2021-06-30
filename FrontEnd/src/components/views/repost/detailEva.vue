<template>
  <div class="detailQuestion">
    <div class="m-model" :class="{ ishowDetailType: ishowDetailType }">
      <div class="back-dialog"></div>
      <div class="revenue-dialog2 dialog">
        <div class="title-form">
          <label class="title-form-revenue"> <b>Thêm loại câu hỏi</b></label>

          <div class="btn-x">
            <button class="btn-close" @click="btCloses()"></button>
          </div>
        </div>
        <el-form
          :model="questiontype"
          :rules="rules"
          ref="questiontype"
          class="demo-ruleForm"
        >
          <div class="content-form4">
            <div class="content-left-input-l">
              <!-- Tên câu hỏi -->
              <div class="form-group">
                <label class="input-name" for=""
                  >Tên loại câu hỏi <b style="color: #d40505">*</b></label
                >
                <el-form-item prop="questionTypeName">
                  <el-input v-model="evalutionCard.questionName"></el-input>
                </el-form-item>
              </div>
            </div>
            <el-form-item
              style="position: absolute; bottom: 0; right: 0; margin-right: 21px"
            >
              <el-button type="primary" class="btn-add" @click="btSave('evalutionCard')"
                >Lưu</el-button
              >
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
    return {};
  },
  props: ["loadEvalutionCard", "ishowDetailType", "btClose", "evalutionCard"],
  methods: {
    btCloses() {
      this.$emit("btClose", true);
    },

    btSave() {
      axios
        .put("https://localhost:44396/api/EvalutionCard", this.evalutionCard)
        .then(() => {
          this.$notify({
            title: "Thành công",
            message: "Sửa câu hỏi thành công",
            type: "success",
          });
          this.$emit("loadEvalutionCard");
          this.$emit("btClose", true);
        });
    },
  },
};
</script>

<style>
.ishowDetailType {
  display: none;
}
.content-form4 {
  width: 100%;
  height: 124px;
  padding-top: 18px;
  display: flex;
}
.revenue-dialog2 {
  height: 230px;
  width: 450px;
  left: calc(50% - 220px);
  position: absolute;
  border: 1px solid #d1f1ff;
  background: white;
  top: calc(50% - 115px);
  z-index: 3;
  border-radius: 3px;
}
</style>
