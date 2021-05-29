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
                <button id="btn" class="btn-add" >Thêm mới</button>
                <button id="btn" class="btn-view" >Xem</button>
                <button id="btn" class="btn-in" >In phiếu</button>
                <button id="btn" class="btn-commit" >Đánh giá</button>
            </div>
        </div>
        <div class="form-table">
            <div class="gread" >
                 <a href="#subPages" data-toggle="collapse" class="collapsed"><i class="lnr lnr-file-empty"></i> <span>Toàn trường</span> <i class="icon-submenu lnr lnr-chevron-left"></i></a>
                            <div id="subPages" class="collapse ">
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
                                <th style="min-width: 130px;white-space: nowrap;">
                                    <label for="">Mã trẻ</label>
                                    <div class="input-search">
                                        <input type="text" />
                                    </div>
                                </th>
                                <th style="min-width: 200px;
                                white-space: nowrap;">
                                    <label for="">Tên trẻ</label>
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
                                 <th style="min-width: 170px;
                                white-space: nowrap;">
                                    <label for="">Phụ huynh</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                 <th style="min-width: 120px;
                                white-space: nowrap;">
                                    <label for="">Ngày</label>
                                    <div class="input-search">

                                        <input type="date"/>
                                    </div>
                                </th>
                                 <th style="min-width: 150px;
                                white-space: nowrap;">
                                    <label for="">Ngày</label>
                                    <div class="input-search">

                                        <input type="text"/>
                                    </div>
                                </th>
                                 <th style="min-width: 150px;
                                white-space: nowrap;">
                                    <label for="">Ngày</label>
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
                                    MS001
                                </td>
                                <td class="text-center">
                                    Tuấn Kiệt
                                </td>
                                 <td class="text-center">
                                    3A 
                                </td>
                                 <td class="text-center">
                                    Nguyễn Văn Quyết
                                </td>
                                 <td class="text-center">
                                    
                                </td>
                                 <td class="text-center">
                                    
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
  
  </div>
</template>

<script>
export default {
    name:'ListEvalution'
}
</script>

<style>
.gread {
    background-color: #EAEBEC;
    width: 17%;
    height: calc(100vh - 217px);
    border: 1px solid #d9d9d9;
    padding: 6px 10px 0px 13px;
}
.list-gread{
    background-color: #ffffff;
    width: 83%;
    height: calc(100vh - 211px);
    border-right: 1px solid #d9d9d9;
}
</style>