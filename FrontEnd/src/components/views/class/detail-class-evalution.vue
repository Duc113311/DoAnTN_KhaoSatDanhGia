<template>
  <div class="detailClassEvalution">
     <div class="m-model" :class="{ showDetail: showDetail }">
        <div class="back-dialog"></div>
        <div class="revenue-dialog-c dialog">
          <div class="title-form">
                <label class="title-form-revenue"> <b>Giao phiếu cho học sinh</b></label>
        
                <div class="btn-x">
                  <button class="btn-close" @click=btClose()></button>
                </div>
          </div>
        <div class="content-form-c">
                  <div class="content-left-input-c">
                            <!-- Tên câu hỏi -->
                             <div class="form-group">
                            <label for="" class="input-name">Tên phiếu đánh giá </label>
                            
                              <select name="" id="" tabindex="2" required ref="feeGroupID" class="form-control-c" >
                                <option value="">Lựa chọn phiếu</option>
                                <option></option>
                                 </select>
                              
                         
                            </div>
                            <div id="feeName_warning" class="validate-warning">
                              Không được để trống
                            </div>
                             <!-- Tên lớp -->
                             <div class="form-group">
                            <label for="" class="input-name">Tên lớp </label>
                              <select name="" id="" tabindex="2" required ref="feeGroupID" class="form-control-c" >
                                <option value="">Lựa chọn phiếu</option>
                                <option></option>
                                 </select>
                            </div>
                            <div id="feeName_warning" class="validate-warning">
                              Không được để trống
                            </div>
                            <!-- Ngày tạo giao phiếu -->
                            <div class="form-group">
                            <label for="" class="input-name">Ngày phát hành phiếu</label>
                              <input type="date" name="" class="form-control-date" id="">
                            </div>
                            <div id="feeName_warning" class="validate-warning">
                              Không được để trống
                            </div>
                            <!-- Ngày kết thúc -->
                            <div class="form-group">
                            <label for="" class="input-name">Ngày kết thúc</label>
                              <input type="date" name="" class="form-control-date" id="">
                            </div>
                            <div id="feeName_warning" class="validate-warning">
                              Không được để trống
                            </div>
                         
                  </div>
                  <div class="content-right-input">
                         <table class="table" >
                             <thead>
                                 <tr>
                                     <th>
                                         <input type="checkbox" name="" id="">
                                     </th>
                                     <th>
                                         Mã học sinh
                                     </th>
                                     <th>
                                         Họ và tên
                                     </th>
                                 </tr>
                             </thead>
                             <tbody>
                                 <tr>
                                     <td scope="row">
                                         <input type="checkbox" name="" id="">
                                     </td>
                                     <td>HS001</td>
                                     <td>Nguyễn Việt Hà</td>
                                 </tr>
                                 <tr>
                                     <td scope="row">
                                         <input type="checkbox" name="" id="">
                                     </td>
                                     <td>HS001</td>
                                     <td>Nguyễn Việt Hà</td>
                                 </tr>
                                 <tr>
                                     <td scope="row">
                                         <input type="checkbox" name="" id="">
                                     </td>
                                     <td>HS001</td>
                                     <td>Nguyễn Việt Hà</td>
                                 </tr>
                                 <tr>
                                     <td scope="row">
                                         <input type="checkbox" name="" id="">
                                     </td>
                                     <td>HS001</td>
                                     <td>Nguyễn Việt Hà</td>
                                 </tr>
                                 <tr>
                                     <td scope="row">
                                         <input type="checkbox" name="" id="">
                                     </td>
                                     <td>HS001</td>
                                     <td>Nguyễn Việt Hà</td>
                                 </tr>

                                 <tr>
                                     <td scope="row">
                                         <input type="checkbox" name="" id="">
                                     </td>
                                     <td>HS001</td>
                                     <td>Nguyễn Việt Hà</td>
                                 </tr>
                                 <tr>
                                     <td scope="row">
                                         <input type="checkbox" name="" id="">
                                     </td>
                                     <td>HS001</td>
                                     <td>Nguyễn Việt Hà</td>
                                 </tr>

                                

                             </tbody>
                         </table>
                         
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
  name:'DetailClassEvalution',

  props:["showDetail"],

  data(){
    return{

    }
  },
  methods:{
    btClose(){
      this.$emit("btClose",true)
    }
  }
}
</script>

<style lang=css>
.showDetail{
    display: none;
}
.form-control-c{
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
.content-left-input-c{
width: 50%;
    float: left;
    padding-left: 20px;
    padding-right: 24px;
    border-right:1px solid #ccc ;
}

.content-form-c {
    width: 100%;
    height: 346px;
    padding-top: 18px;
    display: flex;
    overflow: hidden;
}
.form-control-date{
    width: 50%;
    padding: 6px;
    border: 1px solid #ccc;
    border-radius: 3px;
    outline: none;
    margin: 2px;
}
table, td, th {
  border: 1px solid black;
}

table {
  width: 100%;
  border-collapse: collapse;
}
</style>