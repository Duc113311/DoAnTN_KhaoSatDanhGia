<template>
  <div class="detailQuestion">
    <div class="m-model" :class="{ showDetail: showDetail }">
      <div class="back-dialog"></div>
      <div class="revenue-dialog dialog">
        <div class="title-form">
          <label class="title-form-revenue"> <b>Thêm thông tin câu hỏi</b></label>

          <div class="btn-x">
            <button class="btn-close" @click="btClose()"></button>
          </div>
        </div>
        <div class="content-form">
          <div class="content-left-input">
            <!-- Tên câu hỏi -->
            <div class="form-group">
              <label class="input-name" for=""
                >Tên câu hỏi <b style="color: #d40505">*</b></label
              >
              <input
                type="text"
                class="form-control"
                tabindex="1"
                v-model="question.questionName"
                id="questionName"
                ref="questionName"
                validateRequired="true"
                @blur="onInputRequired('questionName')"
              />
            </div>
            <div id="feeName_warning" class="validate-warning">Không được để trống</div>
            <!-- Nhóm câu hỏi -->
            <div class="form-group">
              <label for="" class="input-name">Thuộc nhóm câu hỏi </label>
              <div class="group-form">
                <select
                  name=""
                  id=""
                  tabindex="2"
                  required
                  ref="feeGroupID"
                  class="form-control"
                >
                  <option value="">Lựa chọn nhóm</option>
                  <option
                    v-for="questinType in questionTypes"
                    :key="questinType.questionTypeID"
                    :value="questinType.questionTypeID"
                  >
                    {{ questinType.questionTypeName }}
                  </option>
                </select>
                <div class="btn-sum" @click="btTypeQuestion"></div>
              </div>
            </div>
            <!-- Mô tả -->
            <div class="form-group">
              <label class="input-name" for=""
                >Mô tả <b style="color: #d40505">*</b></label
              >
              <textarea
                style="height: 90px"
                type="text"
                tabindex="1"
                v-model="question.describe"
                id="describe"
                ref="describe"
              />
            </div>
            <div id="feeName_warning" class="validate-warning">Không được để trống</div>
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
          <button class="btn-add" @click="btSave">Lưu</button>
          <button class="btn-add">Lưu và thêm</button>
          <button class="btn-sort">Đóng</button>
        </div>
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

  props: ["showDetail", "question", "questionTypes"],

  data() {
    return {
      ishowDetailType: true,
    };
  },
  methods: {
    btClose() {
      this.$emit("close", true);
    },
    btCloseType(value) {
      this.ishowDetailType = value;
    },

    btTypeQuestion() {
      this.ishowDetailType = false;
    },

    async btSave() {
      const me = this;
      await axios.post("https://localhost:44396/api/Questions", me.question).then(() => {
        this.$notify({
          title: "Thành công",
          message: "Thêm loại câu hỏi thành công",
          type: "success",
        });
         this.$emit("close", true);
      });
    },
  },
};
</script>

<style></style>
