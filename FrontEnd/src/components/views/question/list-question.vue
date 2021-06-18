<template>
  <div class="list-question">
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
                <button id="btn-Add" class="btn-add" @click="btCreate()">Thêm mới</button>
                <button class="btn-delete" @click="btRemove()"></button>
            </div>
        </div>
        <div class="form-table">
            <div class="tb-data">
                <div class="border-mtb">
                    <table id="tblListRevenue" class="table" style="min-width: 100%;border-collapse: collapse;">
                        <thead>
                            <tr>
                                <th>
                                    <input type="checkbox" name="" id="">
                                </th>
                                <th>
                                    <label for="">STT</label>
                                </th>
                                <th style="min-width: 250px;white-space: nowrap;">
                                    <label for="">Tên câu hỏi</label>
                                    <div class="input-search">
                                        <input type="text" />
                                    </div>
                                </th>
                                 <th style="min-width: 200px;white-space: nowrap;">
                                    <label for="">Nhóm câu hỏi</label>
                                    <div class="input-search">
                                        <input type="text" />
                                    </div>
                                </th>
                               
                                <th class="text-center" style="min-width: 150px;white-space: nowrap;"> 
                                    <label for="">Ngày tạo</label>
                                </th>
                                <th class="text-center">
                                    <label for="">Trạng thái</label>
                                </th>
                                
                                <th class="text-center">

                                </th>

                            </tr>
                        </thead>
                        <tbody>
                            <tr class="style-row" v-for="(item,index) in questions" :key="index">
                                <td scope="row">
                                   <input type="checkbox" name="" id="">
                                </td>
                                <td class="text-center">
                                    {{index++}}
                                </td>
                                 <td class="text-center">
                                    {{item.questionName}}
                                </td>
                                <td class="text-center">
                                    {{item.questionTypeName}}
                                </td>
                                 <td class="text-center">
                                     {{item.createdDate}}
                                </td>
                                 <td class="text-center">
                                    <div :class="{'icon-check-tb':item.questionSatus}">

                                    </div>
                                </td>
                               
                                <td class="text-center">
                                    <div class="btn-function">
                                        <button class="btn-edit"></button>
                                        <button class="btn-duplicate"></button>
                                        <button class="btn-remove" ></button>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <div class="m-dialog">
            <div class="txt-sum" style="padding-left: 11px;">
                Tổng số: <b>{{questions.length}}</b> kết quả
            </div>
        </div>
    </div>   
     
    </div>
    <DetailQuestion 
        @btCreate="btCreate" 
        @close="btClose"
        :showDetail="showDetail"
        :question="question"
        :questionTypes="questionTypes"/>
        <Remove @btRemove="btRemove" :showremove="showremove"/>
  </div>
</template>

<script>
import axios from "axios";
import DetailQuestion from "../question/detail-question.vue"
import Remove from "../../base/baseRemove.vue"
export default {
    name:'ListQuestion',
    components:{
        DetailQuestion,
        Remove
    },
    data(){
        return{
            showDetail:true,
            showremove:true,
            questions:[],
            questionTypes:[],
            question:{}
        }
    },
    methods:{
        
        btRemove(value){
            this.showremove=value
        },
        btCreate(){
            this.showDetail=false
             setTimeout(() => {
                    this.$refs.dialog.$refs.questionName.focus();
                     }, 0);
            this.question={}
        },

        btClose(value){
            this.showDetail=value
        },
       
        async loadData(){
            await axios.get("https://localhost:44396/api/Questions").then((res)=>{
            this.questions=res.data;
        });
        },
         async loadGroupData(){
            await axios.get("https://localhost:44396/api/QuestionType").then((res)=>{
            this.questionTypes=res.data;
        });
        },
    },
    created(){
        this.loadData();
        this.loadGroupData();
        }
}
</script>

<style>

</style>