<template>
  <div class="detailQuestion">
     <div class="m-model" :class="{ showDetail: showDetail }">
        <div class="back-dialog"></div>
        <div class="revenue-dialog dialog">
          <div class="title-form">
                <label class="title-form-revenue"> <b>Thêm thông tin câu hỏi</b></label>
        
                <div class="btn-x">
                  <button class="btn-close" @click=btClose()></button>
                </div>
          </div>
        <div class="content-form">
                  <div class="content-left-input">
                            <!-- Tên câu hỏi -->
                            <div class="form-group">
                              <label class="input-name" for="">Tên câu hỏi <b style="color: #d40505;">*</b></label>
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
                            <label for="" class="input-name">Thuộc nhóm câu hỏi </label>
                            <div class="group-form">
                              <select name="" id="" tabindex="2" required ref="feeGroupID" class="form-control" >
                                <option value="">Lựa chọn nhóm</option>
                                <option></option>
                                 </select>
                              <div class="btn-sum"></div>
                             </div>
                            </div>
                            <!-- Mô tả -->
                            <div class="form-group">
                              <label class="input-name" for="">Mô tả <b style="color: #d40505;">*</b></label>
                              <textarea
                                type="text"
                                class="form-control" 
                                tabindex="1"
                                id="feeName"/>
                            </div>
                            <div id="feeName_warning" class="validate-warning">
                              Không được để trống
                            </div>
                  </div>
                  <div class="content-right-input">
                          <div class="option-check">
                            <label class="title-check">
                              <input type="checkbox" />
                              Hài lòng
                            </label>
                            <label class="title-check"
                              >
                              <input type="checkbox" />
                              Rất hài lòng
                            </label>
                            <label class="title-check"
                              >
                              <input type="checkbox"  />
                              Không hài lòng
                            </label>
                            <label class="title-check"
                              >
                              <input type="checkbox" />
                             Rẩt không hài lòng
                            </label>
                             <label class="title-check"
                              >
                              <input type="checkbox" />
                             Bình thường
                            </label>
                            
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
  name:'DetailQuestion',

  props:["showDetail"],

  data(){
    return{

    }
  },
  methods:{
    btClose(){
      var me=this
      me.showDetail=true
    }
  }
}
</script>

<style>

</style>