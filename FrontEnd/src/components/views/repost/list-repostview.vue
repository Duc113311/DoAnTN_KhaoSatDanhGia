<template>
     <div class="dashBoard">
      <div class="main-content">
          <div class="container-fluid">
              <div class="panel panel-headline">

                <div style="margin: auto;
    padding-bottom: 64px;
    width: 770px;">
                  <div class="btThem">
                    <button @click="addQuestion()">Thêm câu hỏi</button>
                  </div>
                  <div class="btGui">
                     
                    <button>Lưu </button>
                  </div>
                  <div class="title-c">
                  <div class="bor-title">
                  </div>
                  <div class="content-title">
                    <input placeholder="Nhập tiêu đề" class="text" type="text" name="" id="">
                    <input placeholder="Mô tả" class="text" style="padding: 2px 10px !important;" type="text" name="" id="">
                  </div>

                  </div>

                  <div>
                  <div class="content-num"
                  v-for="(item,index) in valueForm"
                  :key="index"
                  >
                    <div class="content-title">
                    <div style="width: 100%;">
                      <input class="txtNum" placeholder="Nhập tiêu đề" type="text" name="" id="">
                      <select class="txtOption" name="" id=""  @change="multiplechoice">
                        <option value="">Tự luận</option>
                        <option value="">Trắc nghiệm</option>
                      </select>
                    </div>
                    <input v-bind:class="{'isShowB':isShowB}" placeholder="Mô tả" class="text" style="padding: 2px 10px !important;" type="text" name="" id="">
                    <div v-bind:class="{'isShowA':isShowA}" class="" style="width: 100%">
                        <div style="display:flex">  
                            <div style="width: 120px;margin-right:10px;display: flex;">
                              <input type="radio" name="" id="">Hài lòng
                            </div>
                            <div style="width: 150px;margin-right:10px;display: flex;">
                              <input type="radio" name="" id="">Rất hài lòng
                            </div>
                            <div style="width: 165px;margin-right:10px;display: flex;">
                              <input type="radio" name="" id="">Không hài lòng
                            </div>
                              <div style="width: 180px;margin-right:10px;display: flex;">
                              <input type="radio" name="" id="">Rất không hài lòng
                            </div>
                              <div style="width: 150px;margin-right:10px;display: flex;">
                              <input type="radio" name="" id="">Bình thường
                            </div>

                      </div>

                    </div>
                   
                    <div>
                      <button @click="removeForm(index)">Xóa</button>
                    </div>
                 
                  </div>

                  </div>
                  <button @click="addQuestion()">Thêm câu hỏi</button>
                  </div>
                  
                  
                </div>

                
            </div>
       </div>
   </div>
</div>
</template>

<script>
export default {
  data(){
    return{
      valueForm:[],
      isShowA:true,
      isShowB:false
    }
  },
  computed:{
    
  },
  methods:{
    // thêm form câu hỏi
    addQuestion(){
      const valueForm={
        Correct:true
      }
      this.valueForm.push(valueForm)
    },
    // Xóa form câu hỏi
    removeForm(index){
      this.valueForm.splice(index,1)
    },
    // Hiển thị tự tuận
    multiplechoice(){
      debugger
      console.log('Vao')
      
      this.isShowA=!this.isShowA
      this.isShowB=true
    },
    essay:function(){
      console.log('hello')
    }
  }

}
</script>

<style lang=css>
.main-content {
    position: absolute;
    top: 61px;
    left: 221px;
    width: calc(100% - 221px);
    background-color: #EAECEF;
    height: calc(100vh - 61px);
    overflow: hidden;
}
.container-fluid {
    padding-right: 19px;
    padding-left: 19px;
    margin-right: auto;
    margin-left: auto;
    height: calc(100vh - 61px);
}
.panel {
    box-shadow: 0 2px 6px rgb(0 0 0 / 8%);
    /* background-color: #fff; */
    margin-bottom: 30px;
    border: 1px solid transparent;
    height: calc(100% - 47px);
    background: #fff;
    margin: 24px 0px;
    overflow: hidden;
    border-radius: 4px;
}
.title-c{
  height: 119px;
    width: 100%;
    overflow: hidden;
    border: 1px solid #ccc;
    border-radius: 13px;
    margin-bottom: 20px;
}
.bor-title{
  background-color: rgb(103, 58, 183);
    color: rgba(255, 255, 255, 1);
    border-top-left-radius: 8px;
    border-top-right-radius: 8px;
    height: 10px;
    left: -1px;
    top: -1px;
    width: calc(100% + 2px);
}

.content-title{
  box-sizing: border-box;
    -webkit-box-flex: 1;
    flex-grow: 1;
    outline: none;
    padding: 12px 25px;
    width: 98%;
}
.text{
  width: 100%;
    padding: 10px;
    border: navajowhite;
    border-bottom: 1px solid #ccc;
    margin-bottom: 14px;
}
.text:focus{
border-color: inherit;
  -webkit-box-shadow: none;
  box-shadow: none;
  outline: none;
}
.content-num{
border: 1px solid #ccc;
    border-radius: 13px;
    margin-top: 20px;
}
.txtNum{
  width: 65%;
    margin-right: 10px;
    padding: 10px;
    border: navajowhite;
    border-bottom: 1px solid #ccc;
    margin-bottom: 14px;
}
.txtOption{
  width: 30%;
    padding-bottom: 8px;
    padding-top: 8px;
    color: #222;
}
.btThem{
  position: absolute;
    border: 1px solid #ccc;
    top: 32px;
    left: 31px;
    border-radius: 5px;
    background: aliceblue;
}
.btGui{
  position: absolute;
    border: 1px solid #ccc;
    top: 32px;
    right: 31px;
    border-radius: 5px;
    background: aliceblue;
    padding-left: 6px;
}
.isShowB{
  display: none;
}
.isShowA{
  display: none;
}
</style>