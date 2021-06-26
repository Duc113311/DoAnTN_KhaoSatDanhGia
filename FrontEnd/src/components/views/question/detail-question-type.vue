<template>
  <div class="detailQuestion">
     <div class="m-model" :class="{ ishowDetailType: ishowDetailType }">
        <div class="back-dialog"></div>
        <div class="revenue-dialog1 dialog">
          <div class="title-form">
                <label class="title-form-revenue"> <b>Thêm loại câu hỏi</b></label>
        
                <div class="btn-x">
                  <button class="btn-close" @click=btClose()></button>
                </div>
          </div>
        <div class="content-form1">
                  <div class="content-left-input-l">
                            <!-- Tên câu hỏi -->
                            <div class="form-group">
                              <label class="input-name" for="">Tên loại câu hỏi <b style="color: #d40505;">*</b></label>
                              <input
                                type="text"
                                class="form-control" 
                                tabindex="1"
                                v-model="questiontype.questionTypeName"
                                id="feeName"/>
                            </div>
                            <div id="feeName_warning" class="validate-warning">
                              Không được để trống
                            </div>  
                            <!-- Mô tả -->
                            <div class="form-group">
                              <label class="input-name" for="">Mô tả <b style="color: #d40505;">*</b></label>
                              <textarea
                              style="height: 50px;"
                              v-model="questiontype.describe"
                                type="text"
                                class="form-control" 
                                tabindex="1"
                                id="feeName"/>
                            </div>
                            <div id="feeName_warning" class="validate-warning">
                              Không được để trống
                            </div>
                           
                  </div>     
          </div>
          <div class="footer-form">
            <button class="btn-add" @click="btSave">Lưu</button>
             <button class="btn-add">Lưu và thêm</button>
          </div>
            
          </div>
     


  </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
    data(){
      return{
      questiontype:{
        questionTypeName:'',
        describe:''
      }
      }
    },
    props:['ishowDetailType'],
    methods:{
        btClose(){
            this.$emit('btCloseType',true)
        },

        async btSave(){
          const me=this;
          await axios .post("https://localhost:44396/api/QuestionType", me.questiontype)
          .then(() => {
            this.$notify({
          title: 'Thành công',
          message: 'Thêm loại câu hỏi thành công',
          type: 'success'
        });
         this.$emit('btCloseType',true)
        }).catch(()=>{
         this.$notify.error({
          title: 'Thất bại',
          message: 'Thêm không thành công'
        });
        })
        }
    }

}
</script>

<style>
.ishowDetailType{
    display: none;
}
.revenue-dialog1 {
    height: 300px;
    width: 450px;
    left: calc(50% - 220px);
    position: absolute;
    border: 1px solid #d1f1ff;
    background: white;
    top: calc(50% - 150px);
    z-index: 3;
    border-radius: 3px;
}
.content-form1 {
    width: 100%;
    height: 172px;
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