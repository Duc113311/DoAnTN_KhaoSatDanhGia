<template>
  <div class="list-evalution-s">
    <div class="misa-content">
      <div class="m-content">
        <div class="title-content">
          <div class="option-title">
            <div class="m-content-title">
              <a href="http://">Khái quát</a>
            </div>
            <div class="m-content-title active">
              <a href="http://">Danh sách phiếu câu hỏi</a>
            </div>
            <div class="m-content-title">
              <a href="http://">Form phiếu câu hỏi</a>
            </div>
          </div>
        </div>
        <div class="content-function">
          <div class="header-left-bt"></div>
          <div class="header-right-bt">
            <button id="btn-Add" class="btn-add" @click="btCreate()">Thêm mới</button>
            <button class="btn-delete" @click="btRemove()"></button>
          </div>
        </div>
        <div class="form-table">
          <div class="tb-data">
            <div class="border-mtb">
              <table
                id="tblListRevenue"
                class="table"
                style="min-width: 100%; border-collapse: collapse"
              >
                <thead>
                  <tr>
                    <th>
                      <input type="checkbox" name="" id="" />
                    </th>
                    <th>
                      <label for="">STT</label>
                    </th>
                    <th style="min-width: 250px; white-space: nowrap">
                      <label for="">Tên phiếu</label>
                      <div class="input-search">
                        <input type="text" />
                      </div>
                    </th>
                    <th style="min-width: 210px; white-space: nowrap">
                      <label for="">Tên câu hỏi</label>
                      <div class="input-search">
                        <input type="text" />
                      </div>
                    </th>
                    <th class="text-center">
                      <label for="">Ngày tạo</label>
                    </th>
                    <th class="text-center">
                      <label for="">Trạng thái</label>
                    </th>

                    <th class="text-center"></th>
                  </tr>
                </thead>
                <tbody>
                  <tr
                    class="style-row"
                    v-for="(i, index) in evalutionCards"
                    :key="i.index"
                  >
                    <td scope="row"></td>
                    <td scope="row">
                      {{ index }}
                    </td>
                    <td class="text-center">
                      {{ i.evalutionName }}
                    </td>
                    <td class="text-center">
                      {{ i.questionName }}
                    </td>
                    <td class="text-center">
                        {{i.createdDate}}
                    </td>
                    <td class="text-center">
                       
                    </td>

                    <td class="text-center">
                      <div class="btn-function">
                        <button class="btn-edit"></button>
                        <button class="btn-duplicate"></button>
                        <button class="btn-remove"></button>
                      </div>
                    </td>
                  </tr>
                </tbody>
              </table>
            </div>
          </div>
        </div>
        <div class="m-dialog">
          <div class="txt-sum" style="padding-left: 11px">Tổng số: <b>11</b> kết quả</div>
        </div>
      </div>
    </div>

    <Remove @btRemove="btRemove" :showremove="showremove" />
  </div>
</template>

<script>
import axios from "axios";
import Remove from "../../base/baseRemove.vue";
export default {
  name: "ListEvalutionCreate",
  components: {
    Remove,
  },
  data() {
    return {
      evalutionCards: [],
      showremove: true,
    };
  },
  methods: {
    btRemove(value) {
      this.showremove = value;
    },
    btCreate() {
      this.$router.push("/chitietphieu");
    },

    async loadEvalutionCard() {
      await axios.get("https://localhost:44396/api/EvalutionCard").then((res) => {
        this.evalutionCards = res.data;
       const loading = this.$loading({
          lock: true,
          text: 'Loading',
          spinner: 'el-icon-loading',
          background: 'rgba(0, 0, 0, 0.7)'
        });
        setTimeout(() => {
          loading.close();
        }, 2000)
      });
    },
  },
  created() {
    this.loadEvalutionCard();
  },
};
</script>

<style></style>
