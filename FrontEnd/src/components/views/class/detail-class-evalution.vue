<template>
  <div class="detailClassEvalution">
    <div class="m-model" :class="{ showDetail: showDetail }">
      <div class="back-dialog"></div>
      <div class="revenue-dialog-c dialog">
        <div class="title-form">
          <label class="title-form-revenue"> <b>Giao phiếu cho học sinh</b></label>

          <div class="btn-x">
            <button class="btn-close" @click="btClose()"></button>
          </div>
        </div>
        <div class="content-form-c">
          <div class="content-left-input-c">
            <!-- Tên câu hỏi -->
            <div class="form-group">
              <label for="" class="input-name">Tên phiếu đánh giá </label>

              <el-select
                v-model="evalutionSubmit.evalutionID"
                style="width: 300px"
                placeholder="Chọn tên phiếu"
              >
                <el-option
                  v-for="item in evalution"
                  :key="item.evalutionID"
                  :label="item.evalutionName"
                  :value="item.evalutionID"
                >
                </el-option>
              </el-select>
            </div>
            <div id="feeName_warning" class="validate-warning">Không được để trống</div>
            <!-- Tên lớp -->
            <div class="form-group">
              <label for="" class="input-name">Tên lớp </label>
              <el-select
                v-model="classChildren.classID"
                style="width: 300px"
                @change="ClickClass(classChildren.classID)"
                placeholder="Chọn tên lớp"
              >
                <el-option
                  v-for="item in classChildren"
                  :key="item.classID"
                  :label="item.className"
                  :value="item.classID"
                >
                </el-option>
              </el-select>
            </div>
            <div id="feeName_warning" class="validate-warning">Không được để trống</div>
          </div>
          <div class="content-right-input" style="overflow: auto; height: 307px">
            <table class="table">
              <thead>
                <tr>
                  <th>
                    <input type="checkbox" name="" id="" />
                  </th>
                  <th>Mã học sinh</th>
                  <th>Họ và tên</th>
                </tr>
              </thead>
              <tbody>
                <tr v-for="i in children" :key="i.childrenID">
                  <td scope="row">
                    <input type="checkbox" name="" id="" @click="ongetChil(i.childrenID)" />
                  </td>
                  <td>{{i.nickName}}</td>
                  <td>{{i.childrenName}}</td>
                </tr>
                
              </tbody>
            </table>
          </div>
        </div>
        <div class="footer-form">
          <button class="btn-add" @click="btSave">Lưu</button>
          <button class="btn-add">Lưu và thêm</button>
          <button class="btn-sort">Đóng</button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  name: "DetailClassEvalution",

  props: ["showDetail"],

  data() {
    return {
      evalution: [],
      
      classChildren: [],
      children:[],
      arrChil:[],

      evalutionSubmit:{
        evalutionID:'',
        listChil:''
      }
    };
  },
  computed:{
  },

  methods: {
    btClose() {
      this.$emit("btClose", true);
    },
    ongetChil(value){
      var me=this;

      me.arrChil.push(value);
    },
    async loadEvalution() {
      await axios.get("https://localhost:44396/api/Evalution").then((res) => {
        this.evalution = res.data;
      });
    },
    async loadChildren() {
      await axios.get("https://localhost:44396/api/Children").then((res) => {
        this.children = res.data;
      });
    },
    async loadClassChildren() {
      await axios.get("https://localhost:44396/api/ClassChildren").then((res) => {
        this.classChildren = res.data;
      });
    },
    
    async ClickClass(value) {
      const me=this;
      await axios
        .get("https://localhost:44396/api/Children/Id?childrenId=" + value)
        .then((res) => {
          me.children = res.data;
        });
    },

    async btSave(){
      const me=this
      me.evalutionSubmit.listChil=me.arrChil.join(',')
      await axios.post("https://localhost:44396/api/EvalutionSubmit/evalutionsubmit", this.evalutionSubmit).then(()=>{
        this.$notify({
           title: 'Thành công',
          message: 'Đã thêm 1 phiếu câu hỏi',
          type: 'success'
        })
      })

    }



  },
  created() {
    this.loadEvalution();
    this.loadClassChildren();
  },
};
</script>

<style lang="css">
.showDetail {
  display: none;
}
.form-control-c {
  width: 92%;
  padding: 7px;
  border: none;
  border: 1px solid #ccc;
}
.revenue-dialog-c {
  height: 480px;
  width: 750px;
  left: calc(50% - 375px);
  position: absolute;
  border: 1px solid #d1f1ff;
  background: white;
  top: calc(50% - 240px);
  z-index: 3;
  border-radius: 3px;
}
.content-left-input-c {
  width: 50%;
  float: left;
  padding-left: 20px;
  padding-right: 24px;
  border-right: 1px solid #ccc;
}

.content-form-c {
  width: 100%;
  height: 346px;
  padding-top: 18px;
  display: flex;
  overflow: hidden;
}
.form-control-date {
  width: 50%;
  padding: 6px;
  border: 1px solid #ccc;
  border-radius: 3px;
  outline: none;
  margin: 2px;
}
table,
td,
th {
  border: 1px solid black;
}

table {
  width: 100%;
  border-collapse: collapse;
}

/* css table */
table,
td,
th {
  border: 1px solid #ddd;
  text-align: left;
}

table {
  border-collapse: collapse;
  width: 100%;
}
table thead tr {
  background: #acb5bbb3;
  z-index: 99;
}
th,
td {
  padding: 15px;
}
</style>
