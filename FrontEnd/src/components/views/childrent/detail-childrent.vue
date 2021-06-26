<template>
  <div class="detailQuestion">
     <div class="m-model" :class="{ showDetail: showDetail }">
        <div class="back-dialog"></div>
        <div class="revenue-dialog-chis dialog">
          <div class="title-form">
                <label class="title-form-revenue"> <b>Thêm thông tin trẻ</b></label>
        
                <div class="btn-x">
                  <button class="btn-close" @click=btClose()></button>
                </div>
          </div>
        <div class="content-form">
          <template>
            <el-form :model="ruleForm" :rules="rules" ref="ruleForm" label-width="120px" class="demo-ruleForm">
            <!-- Tên  -->
            <el-form-item label="Activity name" prop="name">
              <el-input v-model="ruleForm.name"></el-input>
            </el-form-item>
            <!-- Lớp -->
            <el-form-item label="Activity zone" prop="region">
              <el-select v-model="ruleForm.region" placeholder="Activity zone" >
                <el-option label="Zone one" value="shanghai"></el-option>
                <el-option label="Zone two" value="beijing"></el-option>
              </el-select>
            </el-form-item>
            <el-form-item label="Activity form" prop="desc">
              <el-input type="textarea" v-model="ruleForm.desc"></el-input>
            </el-form-item>
            <el-form-item>
              <el-button type="primary" @click="submitForm('ruleForm')">Create</el-button>
              <el-button @click="resetForm('ruleForm')">Reset</el-button>
            </el-form-item>
          </el-form>
          </template>
                
                
          </div>
            
          </div>
     


  </div>
  </div>
</template>

<script>
export default {
  name:'DetailQuestion',

  props:["showDetail"],

  data(){
    return{

      ruleForm: {
          name: '',
          region: '',
          date1: '',
          date2: '',
          delivery: false,
          type: [],
          resource: '',
          desc: ''
        },
        rules: {
          name: [
            { required: true, message: 'Please input Activity name', trigger: 'blur' },
            { min: 3, max: 5, message: 'Length should be 3 to 5', trigger: 'blur' }
          ],
          region: [
            { required: true, message: 'Please select Activity zone', trigger: 'change' }
          ],
          date1: [
            { type: 'date', required: true, message: 'Please pick a date', trigger: 'change' }
          ],
          date2: [
            { type: 'date', required: true, message: 'Please pick a time', trigger: 'change' }
          ],
          type: [
            { type: 'array', required: true, message: 'Please select at least one activity type', trigger: 'change' }
          ],
          resource: [
            { required: true, message: 'Please select activity resource', trigger: 'change' }
          ],
          desc: [
            { required: true, message: 'Please input activity form', trigger: 'blur' }
          ]
        }

    }
  },
  methods:{
    

     submitForm(formName) {
        this.$refs[formName].validate((valid) => {
          if (valid) {
            alert('submit!');
          } else {
            console.log('error submit!!');
            return false;
          }
        });
      },
      resetForm(formName) {
        this.$refs[formName].resetFields();
      }
  }
}
</script>

<style lang=css>
.showDetail{
    display: none;
}
.revenue-dialog-chis{
  height: 600px;
    width: 840px;
    left: calc(50% - 420px);
    position: absolute;
    border: 1px solid #d1f1ff;
    background: white;
    top: calc(50% - 300px);
    z-index: 3;
    border-radius: 3px;
}
</style>