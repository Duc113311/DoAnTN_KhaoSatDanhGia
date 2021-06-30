<template>
  <div class="list-account">
       <div class="misa-content">
 <div class="m-content ">
        <div class="title-content">
            <div class="option-title">
                <div class="m-content-title">
                    <a href="http://">Khái quát</a>
                </div>
                <div class="m-content-title active">
                    <a href="http://">Danh sách tài khảon</a>
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
                <button id="btn-Add" class="btn-add">Thêm mới</button>
                <button class="btn-delete" ></button>
            </div>
        </div>
        <div class="form-table">
            <div class="tb-data">
                <div class="border-mtb">
                    <table id="tblListRevenue" class="table" style="min-width: 100%;border-collapse: collapse;">
                        <thead>
                            <tr>
                                <th>
                                    <div class="checkbox">
                                    </div>
                                </th>
                                <th style="min-width: 250px;white-space: nowrap;">
                                    <label for="">Tên lớp</label>
                                    <div class="input-search">
                                        <input type="text" />
                                    </div>
                                </th>
                                <th style="min-width: 310px;
                                white-space: nowrap;">
                                    <label for="">Tên giáo viên</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                <th style="min-width: 210px;
                                white-space: nowrap;">
                                    <label for="">Tên tài khoản</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                 <th style="min-width: 210px;
                                white-space: nowrap;">
                                    <label for="">Mật khẩu</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                 <th style="min-width: 210px;
                                white-space: nowrap;">
                                    <label for="">Quyền</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                <th style="min-width: 100px;
                                white-space: nowrap;">
                                </th>
                                
                            </tr>
                        </thead>
                        <tbody>
                            <tr class="style-row" v-for="(thongke,index) in thongkes" :key="index" >
                                <td scope="row">
                                   
                                </td>
                                <td class="text-center">
                                    {{thongke.evalutionName}}
                                </td>
                                <td class="text-center">
                                    {{thongke.satisfied}}
                                </td>
                                 <td class="text-center">
                                    {{thongke.unsatisfied}}
                                </td>
                                 <td class="text-center">
                                    {{thongke.verySatisfied}}
                                </td>
                                 <td class="text-center">
                                    {{thongke.veryUnsatisfied}}
                                </td>
                                  <td class="text-center">
                                    {{thongke.normal}}
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
                Tổng số: <b>11</b> kết quả
            </div>
        </div>
    </div>   
     
    </div>
    <DetailAccount/>
  
  </div>
</template>

<script>
import axios from "axios";
import DetailAccount from "../account/detail-account.vue"
export default {
    name:'ListAccount',
    components:{
        DetailAccount
    },
    data(){
        return{
            thongkes:[]
        }
    },
    methods:{
        async LoadData(){
             await axios.get("https://localhost:44396/api/EvalutionSubmit/thongke").then((res)=>{
                 res.data.map(item =>{
                     var sum = item.satisfied + item.unsatisfied + item.verySatisfied + item.veryUnsatisfied + item.normal;
                        item.satisfied=(item.satisfied/sum)*100;
                        item.unsatisfied=(item.unsatisfied/sum)*100;
                        item.verySatisfied=(item.verySatisfied/sum)*100;
                        item.veryUnsatisfied=(item.veryUnsatisfied/sum)*100;
                        item.normal=(item.normal/sum)*100;
                 })
                 this.thongkes = res.data;
             })
        }
       
    },
    created() {
        this.LoadData();
    },
}
</script>

<style>

</style>