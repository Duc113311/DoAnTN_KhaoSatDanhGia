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
                  <div class="content-left-input">
                            <!-- Tên câu hỏi -->
                            <div class="form-group">
                              <label class="input-name" for="">Tên loại câu hỏi <b style="color: #d40505;">*</b></label>
                              <input
                                type="text"
                                class="form-control" 
                                tabindex="1"
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
    props:['ishowDetailType'],
    methods:{
        btClose(){
            this.$emit('btCloseType',true)
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
</style>