<template>
  <div class="list-evalution">
       <div class="misa-content">
        <div class="m-content ">
            <div class="title-content">
                <div class="option-title">
                    <div class="m-content-title">
                        <a href="http://">Khái quát</a>
                    </div>
                    <div class="m-content-title active">
                        <a href="http://">Danh sách câu hỏi</a>
                    </div>
                    <div class="m-content-title">
                        <a href="http://">Form câu hỏi</a>
                    </div>
                
                </div>
            </div>
        <div class="content-function">
            <div class="header-left-bt">
                
            </div>
            <div class="header-right-bt">
                
                
                <button id="btn" class="btn-add">In phiếu</button>
                <button id="btn" class="btn-add" >Đánh giá</button>
            </div>
        </div>
        <div class="form-table">
            
            <div class="list-gread">
                <div class="tb-data">
                <div class="border-mtb">
                    <table id="tblListRevenue" class="table" style="min-width: 100%;border-collapse: collapse;">
                        <thead>
                            <tr>
                                <th style="min-width: 30px;white-space: nowrap;">
                                    <input type="checkbox" name="" id="">
                                </th>
                                <th style="min-width: 230px;white-space: nowrap;">
                                    <label for="">Tên phiếu</label>
                                    <div class="input-search">
                                        <input type="text" />
                                    </div>
                                </th>
                                  <th style="min-width: 100px;
                                white-space: nowrap;">
                                    <label for="">Mã trẻ</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                <th style="min-width: 150px;
                                white-space: nowrap;">
                                    <label for="">Tên trẻ</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                 <th style="min-width: 150px;
                                white-space: nowrap;">
                                    <label for="">Phụ huynh</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                 <th style="min-width: 150px;
                                white-space: nowrap;">
                                    <label for="">Lớp học</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                
                                 <th style="min-width: 150px;
                                white-space: nowrap;">
                                    <label for="">Trạng thái</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                 <th style="min-width: 80px;
                                white-space: nowrap;">
                                    
                                </th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr class="style-row" v-for="i in evalutionSubmit" :key="i.evalutionId">
                                <td scope="row">
                                   <input type="checkbox" name="" id="">
                                </td>
                                <td class="text-center">
                                    {{i.evalutionName}}
                                </td>
                                <td class="text-center">
                                    {{i.childrenCode}}
                                </td>
                                <td class="text-center">
                                    {{i.childrenName}}
                                </td>
                                 <td class="text-center">
                                    {{i.parentName}}
                                </td>
                                 <td class="text-center">
                                    {{i.className}}
                                </td>
                                 <td class="text-center">
                                    {{ientityState}}
                                </td>
                                 <td class="text-center view">
                               
                                        <i @click="btViewEvalution(i.evalutionId)" class="el-icon-view"></i>
                                  
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
            </div>
        </div>
        <div class="m-dialog">
            <div class="txt-sum" style="padding-left: 11px;">
                Tổng số: <b>11</b> kết quả
            </div>
        </div>
    </div>   
     
    </div>
  <DetailEvalution 
    @btViewEvalution="btViewEvalution"
     @close="btclose"
     :evaluDetail="evaluDetail"
     
     :isShowEvalution="isShowEvalution"
     />
  </div>
</template>

<script>
import axios from 'axios';
import DetailEvalution from "../evalution/detail-evalution.vue"
export default {
    name:'ListEvalution',
    components:{
        DetailEvalution
    },
    data(){
        
        return{
            isShowEvalution:true,
            evalutionSubmit:[],
            evaluDetail:{}
        }
    },
    methods:{
       async btViewEvalution(value){
            var me=this;
            me.isShowEvalution=false
            await axios.get("https://localhost:44396/api/EvalutionSubmit/IdEvaluSub?id="+value).then((res) => {
        this.evaluDetail = res.data;
            });

        },
        btclose(value){
            this.isShowEvalution=value
        },

        async loadEvalutionSubmit(){
            await axios.get("https://localhost:44396/api/EvalutionSubmit/getAllSub").then((res) => {
        this.evalutionSubmit = res.data;
        
        
        })
    }
    },

    created(){
        var me =this;

        me.loadEvalutionSubmit();
    }
}
</script>

<style>
.gread {
    background-color: #EAEBEC;
    width: 17%;
    height: calc(100vh - 217px);
    border: 1px solid #d9d9d9;
    padding: 6px 10px 0px 13px;
    font-size: 14px;
}
.list-gread{
    background-color: #ffffff;
    width: 100%;
    height: calc(100vh - 211px);
    border-right: 1px solid #d9d9d9;
}
tbody tr.style-row {
    padding: 10px;
}
.allschool a{
    text-decoration: none;
}
ul li{
    list-style-type: none;
    padding: 5px;
}
ul li a:hover{
    color: burlywood;
}
.view{
    text-align: center;
}
</style>