<template>
  <div class="">
    <div class="manin-d">
      <div class="from-body-c">
        <div class="c-left">
          <div class="logo">
            <img
              style="margin-left: 70px; width: 81px"
              src="../assets/img/logo-truong.png"
              alt=""
              srcset=""
            />
            <label for=""> <h4>Trường mầm non Happy Montessori</h4> </label>
            <label style="width: 220px" for=""
              >Địa chỉ:
              <i
                >155A Đường Vũ Văn Cẩn, Phường Bần Yên Nhân, Thị xã Mỹ Hào, Tỉnh Hưng
                Yên</i
              ></label
            >
            <label for="">Liên hệ: <i>0961.348.219/0221.3768.386</i></label>
            <label for="">Email: happymon247@gmail.com</label>
          </div>
          <el-col :span="8" class="back">
            <el-card shadow="hover"> 
            <i class="el-icon-back"></i> <b>Quay lại</b>  
            </el-card>
          </el-col>
        </div>
        <div class="c-right">
          <div class="s-title">
            <div style="margin-top: 15px">
              <el-input
                placeholder="Nhập từ khóa"
                v-model="input3"
                class="input-with-select"
              >
                <template #prepend>
                  <el-select v-model="select" placeholder="Chọn lớp" style="width: 200px">
                    <el-option label="Restaurant" value="1"></el-option>
                    <el-option label="Order No." value="2"></el-option>
                    <el-option label="Tel" value="3"></el-option>
                  </el-select>
                </template>
                <template #append>
                  <el-button icon="el-icon-search"></el-button>
                </template>
              </el-input>
            </div>
          </div>
          <div class="s-content">
            <div class="item-list">
              <template>
                <el-card class="box-card">
                  <template #header>
                    <div class="card-header">
                      <span style="width: 100px">MS001 - Tuấn Kiệt</span>
                      <el-button style="margin-left: 80px" class="button" type="text">
                        <i class="el-icon-view"></i>
                      </el-button>
                    </div>
                  </template>
                  <div>
                    <label for=""> Phiếu đánh giá ngày hội thiếu nhi...</label>
                  </div>
                </el-card>
              </template>
              <template>
                <el-card class="box-card">
                  <template #header>
                    <div class="card-header">
                      <span style="width: 100px">MS002 - Minh Châu</span>
                      <el-button style="margin-left: 80px" class="button" type="text">
                        <i class="el-icon-view"></i>
                      </el-button>
                    </div>
                  </template>
                  <div>
                    <label for="">Phiếu đánh giá chất lượng đầu vào...</label>
                  </div>
                </el-card>
              </template>
              <template>
                <el-card class="box-card">
                  <template #header>
                    <div class="card-header">
                      <span style="width: 100px">MS003 - Hồng Quân</span>
                      <el-button style="margin-left: 80px" class="button" type="text">
                        <i class="el-icon-view"></i>
                      </el-button>
                    </div>
                  </template>
                  <div>
                    <label for="">Phiếu đánh giá</label>
                  </div>
                </el-card>
              </template>
              <template>
                <el-card class="box-card">
                  <template #header>
                    <div class="card-header">
                      <span style="width: 100px">MS004 - Tuấn Khải</span>
                      <el-button style="margin-left: 90px" class="button" type="text">
                        <i class="el-icon-view"></i>
                      </el-button>
                    </div>
                  </template>
                  <div>
                    <label for="">Phiếu đánh giá</label>
                  </div>
                </el-card>
              </template>
              <template>
                <el-card class="box-card">
                  <template #header>
                    <div class="card-header">
                      <span style="width: 100px">MS005 - Minh Nguyệt</span>
                      <el-button style="margin-left: 70px" class="button" type="text">
                        <i class="el-icon-view"></i>
                      </el-button>
                    </div>
                  </template>
                  <div>
                    <label for="">Phiếu đánh giá</label>
                  </div>
                </el-card>
              </template>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  data() {
    return {};
  },
  methods: {},
};
</script>

<style lang="css">
.manin-d {
  position: absolute;
  top: 0;
  right: 0;
  left: 0;
  bottom: 0;
  background-color: #ffffff;
}
.from-body-c {
  width: 100%;
  height: 100%;
  display: flex;
}
.c-left {
  width: 300px;
  background-color: #ffffff;
  overflow: hidden;
}
.c-right {
  width: calc(100% - 300px);
  background-color: rgb(182 89 212 / 18%);
}
.s-title,
.s-content {
  padding: 13px 30px;
}
.item-list {
  display: grid;
  grid-template-columns: 1fr 1fr 1fr 1fr;
}
.box-card {
  margin: 8px;
}
.logo {
  display: grid;
  justify-content: center;
  position: absolute;
  top: 50px;
  padding: 39px;
  line-height: 32px;
}

.back{
    position: absolute;
    width: 150px;
    padding: 10px;
    bottom: 0;
}
</style>
