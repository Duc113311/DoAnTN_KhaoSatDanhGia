<template>
  <div class="detailEvalutionCreate">
     <div class="m-model" :class="{ showDetail: showDetail }">
        <div class="back-dialog"></div>
        <div class="revenue-dialog-ctr dialog">
          <div class="title-form">
                <label class="title-form-revenue"> <b>Thêm phiếu câu hỏi</b></label>
        
                <div class="btn-x">
                  <button class="btn-close" @click=btClose()></button>
                </div>
          </div>
        <div class="content-form-c">
                  <div class="content-left-input-c">
                            <!-- Tên câu hỏi -->
                            <div class="form-group">
                              <label class="input-name" for="">Tên phiếu <b style="color: #d40505;">*</b></label>
                              <input
                                type="text"
                                class="form-control" 
                                tabindex="1"
                                id="feeName"/>
                            </div>
                            <div id="feeName_warning" class="validate-warning">
                              Không được để trống
                            </div>
                            <!-- Nhóm câu hỏi -->
                            <div class="form-group">
                            <label for="" class="input-name">Loại phiếu </label>
                            <div class="group-form-c">
                              <select name="" id="" tabindex="2" required ref="feeGroupID" class="form-control-c" >
                                <option value="">Lựa chọn loại</option>
                                <option></option>
                                 </select>
                              
                             </div>
                            </div>

                            <!-- Mô tả -->
                             
                           
                  </div>
                  <div class="content-right-input-c">
                         <div class="form-group">
                            <label for="" class="input-name-c">Tên câu hỏi </label>
                            <button class="addEvalution"></button>
                            
                            </div>
                         
                        </div>
                
                
          </div>
          <div class="footer-form">
            <button class="btn-add">Lưu</button>
             <button class="btn-add">Lưu và thêm</button>
          <button class="btn-sort">Đóng</button>
          </div>
            
          </div>
     


  </div>
  </div>
</template>

<script>
export default {
  name:'DetailQuestionCreate',

  props:["showDetail"],

  data(){
    return{

    }
  },
  methods:{
    btClose(){
      this.$emit("close",true)
    }
  }
}
</script>

<style lang=css>

.revenue-dialog-ctr{
    height: 460px;
    width: 790px;
    left: calc(50% - 395px);
    position: absolute;
    border: 1px solid #d1f1ff;
    background: white;
    top: calc(50% - 230px);
    z-index: 3;
    border-radius: 3px;
}
.content-left-input-c{
width: 50%;
    float: left;
    padding-left: 20px;
    padding-right: 24px;
}
.content-right-input-c{
width: 50%;
    float: right;
    padding-left: 20px;
    padding-right: 24px;
}
.content-form-c {
    width: 100%;
    height: 325px;
    padding-top: 18px;
    display: flex;
}
.form-control-c{
   width: 100%;
    padding: 4px;
    border: 1px solid #ccc;
    /* border-radius: 11px; */
    outline: none;
    margin: 2px;
    border: navajowhite;
}
.group-form-c {
    display: flex;
    border: 1px solid #ccc;
    margin: 2px;
    width: 100%;
    border-radius: 4px;
}
.group-form-u {
    display: flex;
  
    margin: 2px;
    width: 100%;
    border-radius: 4px;
}
.input-name-c{
    width: 100%;
    margin-bottom: 8px;
    margin-top: 5px;
}
</style>