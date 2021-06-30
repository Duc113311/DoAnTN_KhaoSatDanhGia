<template>
  <div class="detailEvalution">
     <div class="m-model" :class="{ isShowEvalution: isShowEvalution }">
        <div class="back-dialog"></div>
        <div class="revenue-dialog-evalution dialog">
          <div class="title-form">
               
        
                <div class="btn-x">
                  <button class="btn-close" @click=btClose1()></button>
                </div>
          </div>
        <div class="content-form2">
                <div class="title1">
                    Trường mầm non Happy Montessori
                </div>
                <div class="title2">
                    Địa chỉ: Số 155A đường Vũ Văn Cần, phường Bần Yên Nhân, Mỹ Hào, Hưng Yên
                </div>
                
                <div style=" margin: 10px 18px;">
                    <div class="bor-title"></div>
                    <div class="text-content">
                        <div class="left-text">
                        <div>
                            Hiệu trưởng:  Reina Huyền Nguyễn
                        </div>
                        <div>
                            Cô giáo dạy: {{evaluDetail.teacherName}}
                        </div>
                        <div>
                            Môn: 
                        </div>
                    </div>
                    <div class="right-text">
                        <div>
                            Phụ huynh: Nguyễn Văn Quyết
                        </div>
                        <div>
                            Tên bé: {{evaluDetail.childrenName}}
                        </div>
                        <div>
                            Lớp: {{evaluDetail.className}}
                        </div>
                    </div>
                    </div>
                    </div>
                    
                   
              
                <div class="form-anse">
                <div class="ansew" v-for="(item,index) in evaluDetail.questions" :key="index">
                    <div>
                        Câu {{index+1}}:
                    </div>
                    <div>
                        {{item.questionName ? item.questionName : ''}}
                    </div>
                    <div class="common-radio">
                         <el-radio-group v-model="item.unsatisfied">
                        <el-radio :label="1">Hài lòng</el-radio>
                        <el-radio :label="2">Rất hài lòng</el-radio>
                        <el-radio :label="3">Rất không hài lòng</el-radio>
                        <el-radio :label="4">Không hài lòng</el-radio>
                        <el-radio :label="5">Bình thường</el-radio>
                        </el-radio-group>
                        
                        
                    </div>
                    <div>
                        <input v-model="item.paragraph" class="text-c" type="text" name="" id="">
                    </div>
                </div>
                
                
               
                </div>

                
                
          </div>
       
            
          </div>
     


  </div>
  </div>
</template>

<script>
export default {
  name:'DetailEvalution',

  props:["isShowEvalution","evaluDetail"],

  data(){
    return{

    }
  },
  methods:{
    btClose1(){
     this.$emit('close',true)
    }
  }
}
</script>

<style>
.isShowEvalution{
  display: none;
}
.title1{
    text-align: center;
    font-size: 20px;
    font-weight: 600;
    padding: 10px 13px;
}
.title2{
    text-align: center;
    font-size: 14px;
    font-weight: 600;
    padding: 0px 13px;
}
.text-content{
    overflow: hidden;
    display: grid;
    border: 1px solid #ccc;
    grid-template-columns: 1fr 1fr;
    padding: 5px 8px;
    line-height: 23px;
    background-color: #fff;
}
.ansew{
       padding: 13px 20px;
    margin-bottom: 10px;
    background: #fff;
    border-radius: 9px;
    height: 102px;
    font-size: 14px;
}
.radio-c{
 
    width: 25%;
}
.common-radio{
    width: 100%;
    display: flex;
    margin-top: 10px;
}
.content-form2{
        width: 100%;
    height: 172px;
    padding-top: 18px;
}
.form-anse{
    height: 386px;
     overflow-x: auto; 
     overflow-y: auto; 
    margin-right: auto;
    margin-left: auto;
    width: 95%;
}

.bor-title{
background-color: rgb(103, 58, 183);
    color: rgba(255, 255, 255, 1);
    border-top-left-radius: 8px;
    border-top-right-radius: 8px;
    height: 10px;
    left: -1px;
    top: -1px;
    width: calc(100% + 0px);
}
.text-c:focus{
    outline: none;
}
.text-c{
    width: 96%;
    margin-top: 10px;
    border: navajowhite;
    border-bottom: 1px solid #ccc;
}
</style>