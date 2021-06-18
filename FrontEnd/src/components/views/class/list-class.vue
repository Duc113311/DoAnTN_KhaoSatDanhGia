<template>
  <div class="list-children">
       <div class="misa-content">
 <div class="m-content ">
        <div class="title-content">
            <div class="option-title">
                <div class="m-content-title">
                    <a href="http://">Khái quát</a>
                </div>
                <div class="m-content-title active">
                    <a href="http://">Danh sách trẻ em</a>
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
                                <th style="min-width: 190px;white-space: nowrap;">
                                    <label for="">Tên trẻ</label>
                                    <div class="input-search">
                                        <input type="text" />
                                    </div>
                                </th>
                                 <th style="min-width: 190px;white-space: nowrap;">
                                    <label for="">Phụ huynh</label>
                                    <div class="input-search">
                                        <input type="text" />
                                    </div>
                                </th>
                                <th style="min-width: 150px;
                                white-space: nowrap;">
                                    <label for="">Biệt danh</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                <th style="min-width: 112px;
                                white-space: nowrap;">
                                    <label for="">Độ tuổi</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                <th style="min-width: 170px;
                                white-space: nowrap;">
                                    <label for="">Sinh nhật</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                <th style="min-width: 242px;
                                white-space: nowrap;">
                                    <label for="">Sở thích</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                <th class="text-center" style="min-width: 117px;
                                white-space: nowrap;">
                                    <label for="">Ngày nhập học</label>
                                </th>
                                <th class="text-center">
                                    <label for="">Trạng thái</label>
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
    <DetailClassEvalution
    @btCreate="btCreate"
    :showDetail="showDetail"
    @btClose="btClose" />
        <Remove @btRemove="btRemove" :showremove="showremove"/>
  </div>
</template>

<script>
import DetailClassEvalution from "../class/detail-class-evalution.vue"
import Remove from "../../base/baseRemove.vue"
export default {
    name:'ListClassEvalution',
    components:{
        DetailClassEvalution,
        Remove
    },
    data(){
        return{
            showDetail:true,
            showremove:true,
            array: []
        }
    },
    methods:{
        
        btRemove(value){
            this.showremove=value
        },
        btCreate(){
            this.showDetail=false
            // this.array = ['dfcc310c-dbb5-4517-bcb2-3b0e113c9841','dfcc310c-dbb5-4517-bcb2-3b0e113c9841'];

            // this.array.join(

            // );
        },
        btClose(value){
            this.showDetail=value
        }
    }
}
</script>

<style>

</style>