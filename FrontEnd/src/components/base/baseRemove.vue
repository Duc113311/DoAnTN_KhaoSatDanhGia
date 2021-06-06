<template>
  <div class="m-alert alert-detail" :class="{showremove:showremove}">
      <div id="alert-delete" class="m-alert alert-detail">
            <div class="m-alert alert-modal">
            </div>
            <div id="alrt-content" class="alert-content" style="top: calc(40% - 0px); left: calc(50% - 0px);">
                  <div class="alert-header">
                      <div class="alert-header-title">Thông báo</div>
                      <div id="alert-close" class="alert-header-close" >
                            <button @click="btClose">
                            </button>
                      </div>
                  </div>
                       <div class="alert-body"> Bạn có chắc chắn muốn xóa những bản ghi đã chọn? </div>
                        <div class="alert-footer"><button id="btnCancle" class="m-btn-close">Không</button>
                        <button id="btnDelete" class="m-btn-delete">Xóa</button>
                         </div>
            </div>
        </div>
    </div>
</template>

<script>
export default {
    name:'Remove',
    data(){
        return{

        }
    },
    props:["showremove"],
    methods:{
        btClose(){
            this.$emit('btRemove',true)
        }
    }

}
</script>

<style lang=css>
.showremove{
    display: none;
}
.m-alert {
    position: static;
}   
.m-alert .alert-modal {
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background-color: black;
    z-index: 999;
    opacity: .5;
}
.m-alert .alert-content {
    width: 350px;
    transform: translateX(-50%);
    position: absolute;
    border: 1px solid #d1f1ff;
    background: white;
    z-index: 1000;
    height: 150px;
    padding: 12px;
}

.m-alert .alert-content .alert-header {
    display: flex;
    /* width: 100%; */
    height: 49px;
    align-items: center;
    padding: 0px 8px;
}
.alert-header-title {
    font-size: 20px;
    font-weight: bold;
}
.m-alert .alert-content .alert-header-close {
    position: absolute;
    right: 0;
    top: 0;
}
.m-alert .alert-content .alert-header-close button {
    width: 40px;
    height: 40px;
    border: none;
    outline: none;
    cursor: pointer;
    border-radius: 0 5px 0 0;
    background-image: url(../../assets/img/ic_close_16.png);
    background-position: center;
    background-repeat: no-repeat;
    background-size: 16px;
    opacity: .7;
}
button {
    background: none;
    padding: 8px;
    border: none;
    border-radius: 3px;
    font-size: 13px;
    margin-right: 10px;
    outline: none;
}
.alert-body {
    height: 37px;
    padding: 14px;
    font-size: 13px;
}
.alert-footer {
    height: 44px;
    /* padding: 14px; */
    font-size: 13px;
    width: 100%;
    align-items: center;
    display: flex;
    justify-content: flex-end;
}
.alert-footer .m-btn-close {
    margin-right: 8px;
    width: 100px;
    border: 1px solid #ccc;
}
.m-btn-delete {
    width: 100px;
    border: 1px solid #ccc;
    background: #03C573;
    color: #fff;
}
</style>