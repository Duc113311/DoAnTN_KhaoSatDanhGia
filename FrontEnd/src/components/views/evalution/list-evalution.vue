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
                
                <button id="btn" class="btn-add" @click="btViewEvalution()">Xem</button>
                <button id="btn" class="btn-add">In phiếu</button>
                <button id="btn" class="btn-add" >Đánh giá</button>
            </div>
        </div>
        <div class="form-table">
            <div class="gread" >
                <div class="allschool">
                     <a href="#subPages" data-toggle="collapse" class="collapsed">
                     <span>Toàn trường</span> 
                    </a>
                </div>
                <div id="subPages" class="allschool">
                                <ul class="nav">
                                    <li>
                                        <a href="#" class="">Lớp 2 tuổi</a>
                                        <div id="subPages" class="collapse ">
                                            <ul class="nav">
                                                <li>
                                                    <a href="#" class="">2A</a>
                                                </li>
                                                <li><a href="#" class="">2B</a></li>
                                                <li><a href="#" class="">2C</a></li>
                                                <li><a href="#" class="">2D</a></li>
                                            </ul>
                                         </div>
                                    </li>
                                    <li><a href="#" class="">Lớp 3 tuổi</a>
                                        <div id="subPages" class="collapse ">
                                            <ul class="nav">
                                                <li>
                                                    <a href="#" class="">3A</a>
                                                </li>
                                                <li><a href="#" class="">3B</a></li>
                                                <li><a href="#" class="">3C</a></li>
                                                <li><a href="#" class="">3D</a></li>
                                            </ul>
                                         </div>
                                    </li>
                                    <li><a href="#" class="">Lớp 4 tuổi</a></li>
                                    <li><a href="#" class="">Lớp 5 tuổi</a></li>
                                </ul>
                </div>

            </div>
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
                                  <th style="min-width: 230px;white-space: nowrap;">
                                    <label for="">Loại phiếu</label>
                                    <div class="input-search">
                                        <input type="text" />
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
                                 <th style="min-width: 80px;
                                white-space: nowrap;">
                                    <label for="">Ngày</label>
                                    <div class="input-search">

                                        <input type="date"/>
                                    </div>
                                </th>
                                 <th style="min-width: 150px;
                                white-space: nowrap;">
                                    <label for="">Trạng thái</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                
                                

                                

                            </tr>
                        </thead>
                        <tbody>
                            <tr class="style-row" >
                                <td scope="row">
                                   <input type="checkbox" name="" id="">
                                </td>
                                <td class="text-center">
                                    Đón xuân năm mới
                                </td>
                                <td class="text-center">
                                    Tuấn Kiệt
                                </td>
                                 <td class="text-center">
                                    Nguyễn Văn Quyết
                                </td>
                                 <td class="text-center">
                                    23/02/2021
                                </td>
                                 <td class="text-center">
                                    
                                </td>
                                 <td class="text-center">
                                    
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
     :isShowEvalution="isShowEvalution"/>
  </div>
</template>

<script>
import DetailEvalution from "../evalution/detail-evalution.vue"
export default {
    name:'ListEvalution',
    components:{
        DetailEvalution
    },
    data(){
        
        return{
            isShowEvalution:true
        }
    },
    methods:{
        btViewEvalution(){
            var me=this;
            me.isShowEvalution=false
        },
        btclose(value){
            this.isShowEvalution=value
        }
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
    width: 83%;
    height: calc(100vh - 211px);
    border-right: 1px solid #d9d9d9;
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
</style>