<template>
  <div class="">
    <div class="manin-d">
      <div class="from-body-c">
        <div class="c-left">
          <div class="logo">
            <img
              style="margin-left: 70px; width: 81px"
              src="../assets/img/logo-truong.png"
              alt=""
              srcset=""
            />
            <label for=""> <h4>Trường mầm non Happy Montessori</h4> </label>
            <label style="width: 220px" for=""
              >Địa chỉ:
              <i
                >155A Đường Vũ Văn Cẩn, Phường Bần Yên Nhân, Thị xã Mỹ Hào, Tỉnh Hưng
                Yên</i
              ></label
            >
            <label for="">Liên hệ: <i>0961.348.219/0221.3768.386</i></label>
            <label for="">Email: happymon247@gmail.com</label>
          </div>
          <el-col :span="8" class="back" >
            <el-card shadow="hover" >
              <div @click="onback">
                <i class="el-icon-back"></i> <b>Quay lại</b>
              </div>
            </el-card>
          </el-col>
        </div>
        <div class="c-right">
          <div class="s-title">
            <div style="margin-top: 15px">
              <el-input
                placeholder="Nhập từ khóa"
                 @change="onclickFilter()"
                v-model="classChil.querytext"
                class="input-with-select"
              >
                <template #prepend>
                  <el-select 
                  @change="onclickFilter()"
                  v-model="classChil.classID" 
                  placeholder="Chọn lớp" 
                  style="width: 200px">
                    <el-option 
                    v-for="classChil in classChils"
                    :key="classChil.classID"
                    :label="classChil.className"
                     :value="classChil.classID"></el-option>
                    
                  </el-select>
                </template>
                <template #append>
                  <el-button icon="el-icon-search"></el-button>
                </template>
              </el-input>
            </div>
          </div>
          <div class="s-content" style="height: 641px;
    overflow: scroll;">
            <div class="item-list">
              <div
                v-for="chillEvaluSubmit in chillEvaluSubmits"
                :key="chillEvaluSubmit.childrenID"
              >
                <template>
                  <el-card class="box-card">
                    <template #header>
                      <div class="card-header">
                        <div class="e-left" style="width: 170px;">
                        <span style="width: 100px"><b>Phụ huynh:</b></span><br>
                        <span style="width: 100px">{{chillEvaluSubmit.childrenCode}}-{{chillEvaluSubmit.childrenName}}</span>
                        </div>
                        <div class="e-right">
                          <el-button style="margin-left: 42px" class="button" type="text" @click="viewEvaluChil(chillEvaluSubmit.evalutionId)">
                          <i class="el-icon-view"></i>
                        </el-button>
                        </div>
                       
                        
                      </div>
                    </template>
                    <div>
                      <label for=""> {{chillEvaluSubmit.evalutionName}}</label>
                    </div>
                  </el-card>
                </template>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

    <BaseEvalSubmi 
    :isShowEvaluChi="isShowEvaluChi"
    :chillEvaluSubmit="chillEvaluSubmit"
    ></BaseEvalSubmi>
  </div>
</template>

<script>
import BaseEvalSubmi from './base/baseEvuluSubmit.vue'
import axios from "axios";
export default {
  components:{
    BaseEvalSubmi
  },
  data() {
    return {
      chillEvaluSubmits: [],
      isShowEvaluChi:true,
      chillEvaluSubmit:{},
      classChils:[],
      classChil:{}
    };
  },
  methods: {
    async loadAllChiSubmit() {
      await axios
        .get("https://localhost:44396/api/EvalutionSubmit/getAllSub")
        .then((res) => {
          this.chillEvaluSubmits = res.data;
        });
    },
    viewEvaluChil(value){
      this.isShowEvaluChi=false
      var me=this;

       axios.get("https://localhost:44396/api/EvalutionSubmit/IdEvaluSub?id="+value).then((res) => {
        me.chillEvaluSubmit = res.data;
            });
    },

    async loadDataChil(){
       await axios
        .get("https://localhost:44396/api/ClassChildren")
        .then((res) => {
          this.classChils = res.data;
        });
    },

    onclickFilter(){
      console.log(this.classChil.classID)
      console.log(this.classChil.querytext)

      var param=
        `classID=${this.classChil.classID}` + 
        `&childrenName=${this.classChil?.querytext}`;
      
       axios.get("https://localhost:44396/api/EvalutionSubmit/AllChil?"+param)
        .then((res) => {
          this.chillEvaluSubmits = res.data;
          console.log(res.data);
        });
    },

    onback(){
      this.$router.go(-1);
    }
  },
  mounted() {
    this.loadAllChiSubmit();
    this.loadDataChil();
  },
};
</script>

<style lang="css">
.manin-d {
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  bottom: 0;
  background-color: #ffffff;
}
.from-body-c {
  width: 100%;
  height: 100%;
  display: flex;
}
.c-left {
  width: 300px;
  background-color: #ffffff;
  overflow: hidden;
}
.c-right {
  width: calc(100% - 300px);
  background-color: rgb(182 89 212 / 18%);
}
.s-title,
.s-content {
  padding: 13px 23px;
}
.item-list {
  display: grid;
  grid-template-columns: 1fr 1fr 1fr 1fr;
}
.box-card {
  margin: 8px;
}
.logo {
  display: grid;
  justify-content: center;
  position: absolute;
  top: 50px;
  padding: 39px;
  line-height: 32px;
}

.back {
  position: absolute;
  width: 150px;
  padding: 10px;
  bottom: 0;
}
.card-header{
  display: flex;
}
</style>
