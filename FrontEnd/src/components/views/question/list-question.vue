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
                <button class="btn-delete" @click="btRemoveAll()"></button>
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
                                        <input type="text"  v-model="filterText" @keyup.enter="btnfinter"/>
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

                                </th>

                            </tr>
                        </thead>
                        <tbody>
                            <tr class="style-row" v-for="(question,index) in questions" :key="index">
                                <td scope="row">
                                   <input @click="checkBoxInfo(question)" type="checkbox"
                                    v-model="question.questionSatus" name="" id="">
                                </td>
                                <td class="text-center">
                                    {{index++}}
                                </td>
                                 <td class="text-center">
                                    {{question.questionName}}
                                </td>
                                <td class="text-center">
                                    {{question.questionTypeName}}
                                </td>
                                 <td class="text-center">
                                     {{question.createdDate}}
                                </td>
                                
                               
                                <td class="text-center">
                                    <div class="btn-function">
                                        <button class="btn-edit" @click="rowOnClick(question)"></button>
                                        <button class="btn-duplicate"></button>
                                        <button class="btn-remove" @click="btRemoveDetail(question)"></button>
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
     :fomatDialog="fomatDialog"
        :showDetail="showDetail"
        :isUpdateTitle="isUpdateTitle"
        :isAddTitle="isAddTitle"
        :question="question"
        @loadData="loadData"
        :questionTypes="questionTypes"/>
        <Remove @btRemove="btRemove" :question="question" :showremove="showremove" @removeDetail="removeDetail"/>
        <RemoveAll @deleteAllBox="deleteAllBox" @btRemoveAll="btRemoveAll" :showremoveAll="showremoveAll" />
  
  </div>
</template>

<script>
import axios from "axios";
import DetailQuestion from "../question/detail-question.vue"
import Remove from "../../base/baseRemove.vue"
import RemoveAll from "../../base/baseRemoveAll.vue"
export default {
    name:'ListQuestion',
    components:{
        DetailQuestion,
        Remove,
        RemoveAll
    },
    data(){
        return{
             isAddTitle:false,
            isUpdateTitle:false,
            showDetail:true,
            showremove:true,
            showremoveAll:true,
            questions:[],
            fomatDialog:1,
            questionTypes:[],
            question:{
                questionName:'',
                questionTypeID:'',
                createdDate:'',
                describe:'',
                satisfied:0,
                questionSatus:0,
                paragraph:''
            },
           
            arrData:[]
        }
    },
    methods:{
        /**
         * Lọc dữ liệu qua các ô text
         * Trả về danh sách đối tượng tìm được
         * Create by NVDuc(28/03/2021)
         */
        btnfinter(){
            if(this.filterText!=""){
                    axios.get("https://localhost:44396/api/Questions/Filter?a="+this.filterText).then(res=>{
                this.questions = res.data;
            })
            }else{
                this.loadData();
            }
        },
       
        btRemove(value){
            this.showremove=value
        },
        btCreate(){
            this.isAddTitle=false;
             this.isUpdateTitle=true;
            this.showDetail=false
            this.question={}
        },
        rowOnClick(emp){
            this.isUpdateTitle=false
            this.isAddTitle=true;
            this.showDetail=false
            this.question=JSON.parse(JSON.stringify(emp))
            console.log(emp)
        },

        btClose(value){
            this.showDetail=value
        },
        btRemoveDetail(ept){
             this.showremove=false;
             this.question=JSON.parse(JSON.stringify(ept));
             console.log('ádas',ept)
        },

        removeDetail(){
            console.log('sadas',this.question.questionID)
            axios.delete("https://localhost:44396/api/Questions/"+this.question.questionID)
            .then(()=>{
                 this.$notify({
                        title: "Thông báo",
                        message: "Xóa câu hỏi thành công",
                        type: "success",
                });
                this.showremove=true;
                this.loadData();
            })
        },
         /**
         * Kiểm tra dữ liệu được truyền vào ô CheckBox
         * Chức năng xóa nhiều
         * Create by NVDuc(28/03/2021)
         */
        checkBoxInfo(emp){
            if(emp.questionSatus == 0 || emp.questionSatus == false)
                this.arrData.push(emp.questionID);
            else{
                console.log(emp.questionID);
                var index = this.arrData.findIndex(x => x === emp.questionID);
                this.arrData.splice(index,1);
            }
        },
         btRemoveAll(value){
            this.showremoveAll=value;
            
        },
        deleteAllBox(){
            axios.delete("https://localhost:44396/api/Questions/DeleteAll/",
            {
              headers: {
                Authorization: "authorizationToken",
              },
              data: this.arrData,
            }).
            then(() => {
              console.log(this.arrData);
                 this.$notify({
                    title: "Thành công",
                    message: "Thêm câu hỏi thành công",
                    type: "success",
                    });
            });
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