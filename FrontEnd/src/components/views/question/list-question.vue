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
                                    <label for="">Tên câu hỏi</label>
                                    <div class="input-search">
                                        <input type="text" />
                                    </div>
                                </th>
                                <th style="min-width: 310px;
                                white-space: nowrap;">
                                    <label for="">Mô tả</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                

                                <th class="text-center">
                                    <label for="">Hài lòng</label>
                                </th>
                                <th class="text-center">
                                    <label for="">Rất hài lòng</label>
                                </th>
                                <th class="text-center">
                                    <label for="">Không hài lòng</label>
                                </th>
                                <th class="text-center">
                                    <label for="">Rất không hài lòng</label>
                                </th>
                                <th class="text-center">
                                    <label for="">Khoản thu bắt buộc</label>
                                </th>
                                <th class="text-center">
                                    <label for="">Bình thường</label>
                                </th>
                                <th class="text-center">

                                </th>

                            </tr>
                        </thead>
                        <tbody>
                            <tr class="style-row" >
                                <td scope="row">
                                   
                                </td>
                                <td class="text-center">
                                    
                                </td>
                                <td class="text-center">
                                    
                                </td>
                                 <td class="text-center">
                                    
                                </td>
                                 <td class="text-center">
                                    
                                </td>
                                 <td class="text-center">
                                    
                                </td>
                                 <td class="text-center">
                                    
                                </td>
                                 <td class="text-center">
                                    
                                </td>
                                <td class="text-center">
                                    
                                     
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
    <DetailQuestion 
        @btCreate="btCreate" 
        @close="btClose"
        :showDetail="showDetail"/>
  </div>
</template>

<script>
import DetailQuestion from "../question/detail-question.vue"
export default {
    name:'ListQuestion',
    components:{
        DetailQuestion
    },
    data(){
        return{
            showDetail:true
        }
    },
    methods:{

        btCreate(){
            this.showDetail=false
        },
        btClose(value){
            this.showDetail=value
        }
    }
}
</script>

<style>

</style>