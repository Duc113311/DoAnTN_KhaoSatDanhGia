<template>
  <div class="dashBoard">
      <div class="main-content">
          <div class="container-fluid">
              <div class="panel panel-headline">
                  <div class="panel-heading">
                      <h3 class="panel-title">Thống kê hàng tháng</h3>
                      <p class="panel-subtitle">
                          <input type="date" name="" id="">
                      </p>
                  </div>
                  <div class="panel-body">
                      <div class="row">
								<div class="col-md-3">
									<div class="metric">
										<span class="icon">
                                            <i class="el-icon-s-data" style="font-size: 25px"></i>
                                        </span>
										<p>
											<span class="number">1,252</span>
											<span class="title">Số phiếu phát hành</span>
										</p>
									</div>
								</div>
								<div class="col-md-3">
									<div class="metric">
										<span class="icon">
                                            <i class="el-icon-s-custom" style="font-size: 25px"></i>
                                        </span>
										<p>
											<span class="number">203</span>
											<span class="title">Trẻ nhập học</span>
										</p>
									</div>
								</div>
								<div class="col-md-3">
									<div class="metric">
										<span class="icon">
                                            <i class="el-icon-s-order" style="font-size: 25px"></i>
                                        </span>
										<p>
											<span class="number">274,678</span>
											<span class="title">Câu hỏi</span>
										</p>
									</div>
								</div>
								<div class="col-md-3">
									<div class="metric">
										<span class="icon">
                                            <i class="el-icon-s-help" style="font-size: 25px;margin-top: 11px;"></i>
                                        </span>
										<p>
											<span class="number">35%</span>
											<span class="title">Lớp học</span>
										</p>
									</div>
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

}
</script>

<style lang=css>
.main-content {
    position: absolute;
    top: 61px;
    left: 221px;
    width: calc(100% - 221px);
    background-color: #EAECEF;
    height: calc(100vh - 61px);
    overflow: hidden;
}
.container-fluid {
    padding-right: 19px;
    padding-left: 19px;
    margin-right: auto;
    margin-left: auto;
    height: calc(100vh - 61px);
}
.panel{
    box-shadow: 0 2px 6px rgb(0 0 0 / 8%);
    background-color: #fff;
    margin-bottom: 30px;
    border: 1px solid transparent;
    height: calc(100% - 47px);
    background: #fff;
    margin: 24px 0px;
    overflow: hidden;
    border-radius: 4px;
}
.panel.panel-headline .panel-heading{
    border-bottom: none;
}
.panel .panel-heading{
padding-top: 20px;
    padding-bottom: 20px;
    position: relative;
    padding-left: 25px;
    padding-right: 25px;
    border-top-left-radius: 3px;
    border-top-right-radius: 3px;
}
.panel.panel-headline .panel-heading .panel-title {
    margin-bottom: 8px;
    font-size: 22px;
    font-weight: normal;
}
.panel.panel-headline .panel-heading .panel-subtitle {
    margin-bottom: 0;
    font-size: 14px;
    color: #8D99A8;
}
.panel .panel-body {
    padding-top: 10px;
    padding-bottom: 15px;
    padding-left: 25px;
    padding-right: 25px;
}
.row {
    margin-right: -15px;
    margin-left: -15px;
}
@media (min-width: 992px){
.col-md-3 {
    width: 22%;
    float: left;
}
}
.col-md-3{
    position: relative;
    min-height: 1px;
    padding-right: 15px;
    padding-left: 15px;
}
.metric{
border-radius: 3px;
    padding: 20px;
    margin-bottom: 30px;
    border: 1px solid #DCE6EB;
}
.metric .icon{
border-radius: 50%;
    float: left;
    width: 50px;
    height: 50px;
    line-height: 50px;
    background-color: #0081c2;
    text-align: center;
}
.metric .icon i {
    font-size: 18px;
    color: #fff;
}

.metric p {
    margin-bottom: 0;
    line-height: 1.2;
    text-align: right;
}
.metric .number {
    display: block;
    font-size: 28px;
    font-weight: 300;
}
.metric .title {
    font-size: 16px;
}

</style>