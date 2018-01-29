/*
 * applyKerasTrainedModel.cpp
 *
 * Code generation for function 'applyKerasTrainedModel'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "applyKerasTrainedModel_emxutil.h"
#include "eml_error.h"
#include "sigmoid.h"
#include "eml_int_forloop_overflow_check.h"
#include "applyKerasTrainedModel_mexutil.h"
#include "applyKerasTrainedModel_data.h"

/* Variable Definitions */
static emlrtRSInfo emlrtRSI = { 17, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m"
};

static emlrtRSInfo b_emlrtRSI = { 21, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m"
};

static emlrtRSInfo c_emlrtRSI = { 25, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m"
};

static emlrtRSInfo d_emlrtRSI = { 33, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtRSInfo e_emlrtRSI = { 47, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtRSInfo f_emlrtRSI = { 54, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtRSInfo g_emlrtRSI = { 69, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtRSInfo h_emlrtRSI = { 22, "eml_int_forloop_overflow_check",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_int_forloop_overflow_check.m"
};

static emlrtRSInfo i_emlrtRSI = { 68, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtRSInfo j_emlrtRSI = { 21, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtRSInfo k_emlrtRSI = { 54, "eml_xgemm",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\blas\\eml_xgemm.m"
};

static emlrtRSInfo l_emlrtRSI = { 1, "xgemm",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\coder\\coder\\+coder\\+internal\\+blas\\xgemm.p"
};

static emlrtRSInfo m_emlrtRSI = { 61, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtRSInfo n_emlrtRSI = { 30, "eml_xdotu",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\blas\\eml_xdotu.m"
};

static emlrtRSInfo o_emlrtRSI = { 1, "xdotu",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\coder\\coder\\+coder\\+internal\\+blas\\xdotu.p"
};

static emlrtRSInfo p_emlrtRSI = { 1, "xdot",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\coder\\coder\\+coder\\+internal\\+blas\\xdot.p"
};

static emlrtMCInfo emlrtMCI = { 53, 5, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtMCInfo b_emlrtMCI = { 52, 15, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtMCInfo c_emlrtMCI = { 51, 13, "eml_assert_valid_size_arg",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_assert_valid_size_arg.m"
};

static emlrtMCInfo d_emlrtMCI = { 50, 23, "eml_assert_valid_size_arg",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_assert_valid_size_arg.m"
};

static emlrtMCInfo e_emlrtMCI = { 57, 5, "eml_assert_valid_size_arg",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_assert_valid_size_arg.m"
};

static emlrtMCInfo f_emlrtMCI = { 56, 15, "eml_assert_valid_size_arg",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_assert_valid_size_arg.m"
};

static emlrtMCInfo i_emlrtMCI = { 99, 13, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtMCInfo j_emlrtMCI = { 98, 23, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtMCInfo k_emlrtMCI = { 104, 13, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtMCInfo l_emlrtMCI = { 103, 23, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtRTEInfo emlrtRTEI = { 1, 27, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m"
};

static emlrtRTEInfo b_emlrtRTEI = { 51, 1, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtRTEInfo c_emlrtRTEI = { 16, 1, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m"
};

static emlrtBCInfo emlrtBCI = { -1, -1, 17, 55, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo b_emlrtBCI = { -1, -1, 17, 24, "weight",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtDCInfo emlrtDCI = { 17, 24, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  1 };

static emlrtBCInfo c_emlrtBCI = { -1, -1, 17, 72, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo d_emlrtBCI = { -1, -1, 17, 122, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo e_emlrtBCI = { -1, -1, 17, 151, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo f_emlrtBCI = { -1, -1, 17, 165, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtDCInfo b_emlrtDCI = { 17, 100, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  1 };

static emlrtBCInfo g_emlrtBCI = { -1, -1, 17, 100, "weight",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtECInfo emlrtECI = { -1, 17, 16, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m"
};

static emlrtBCInfo h_emlrtBCI = { -1, -1, 18, 27, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo i_emlrtBCI = { -1, -1, 19, 19, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtDCInfo c_emlrtDCI = { 21, 28, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  1 };

static emlrtBCInfo j_emlrtBCI = { -1, -1, 21, 28, "weight",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo k_emlrtBCI = { -1, -1, 21, 84, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo l_emlrtBCI = { -1, -1, 21, 98, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtDCInfo d_emlrtDCI = { 21, 120, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  1 };

static emlrtBCInfo m_emlrtBCI = { -1, -1, 21, 120, "weight",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtECInfo b_emlrtECI = { -1, 21, 20, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m"
};

static emlrtDCInfo e_emlrtDCI = { 25, 16, "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  1 };

static emlrtBCInfo n_emlrtBCI = { -1, -1, 25, 16, "weight",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo o_emlrtBCI = { -1, -1, 25, 66, "weight",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo p_emlrtBCI = { -1, -1, 1, 1, "", "xgemm",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\coder\\coder\\+coder\\+internal\\+blas\\xgemm.p",
  0 };

static emlrtBCInfo q_emlrtBCI = { -1, -1, 1, 1, "", "xdot",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\coder\\coder\\+coder\\+internal\\+blas\\xdot.p",
  0 };

static emlrtDCInfo f_emlrtDCI = { 51, 48, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m",
  4 };

static emlrtBCInfo r_emlrtBCI = { -1, -1, 25, 39, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo s_emlrtBCI = { -1, -1, 21, 51, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo t_emlrtBCI = { -1, -1, 21, 67, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo u_emlrtBCI = { -1, -1, 21, 135, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo v_emlrtBCI = { -1, -1, 21, 151, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo w_emlrtBCI = { -1, -1, 21, 173, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo x_emlrtBCI = { -1, -1, 21, 189, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo y_emlrtBCI = { -1, -1, 21, 203, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo ab_emlrtBCI = { -1, -1, 22, 23, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo bb_emlrtBCI = { -1, -1, 22, 39, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtBCInfo cb_emlrtBCI = { -1, -1, 23, 23, "NodesArray",
  "applyKerasTrainedModel",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\applyKerasTrainedModel.m",
  0 };

static emlrtRSInfo r_emlrtRSI = { 56, "eml_assert_valid_size_arg",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_assert_valid_size_arg.m"
};

static emlrtRSInfo s_emlrtRSI = { 50, "eml_assert_valid_size_arg",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_assert_valid_size_arg.m"
};

static emlrtRSInfo t_emlrtRSI = { 98, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtRSInfo u_emlrtRSI = { 103, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtRSInfo v_emlrtRSI = { 52, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtRSInfo w_emlrtRSI = { 57, "eml_assert_valid_size_arg",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_assert_valid_size_arg.m"
};

static emlrtRSInfo x_emlrtRSI = { 99, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtRSInfo y_emlrtRSI = { 104, "eml_mtimes_helper",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\ops\\eml_mtimes_helper.m"
};

static emlrtRSInfo ab_emlrtRSI = { 53, "reshape",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\elmat\\reshape.m"
};

static emlrtRSInfo cb_emlrtRSI = { 51, "eml_assert_valid_size_arg",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_assert_valid_size_arg.m"
};

/* Function Declarations */
static const mxArray *b_message(const emlrtStack *sp, const mxArray *b, const
  mxArray *c, const mxArray *d, emlrtMCInfo *location);
static void eml_assert_valid_size_arg(const emlrtStack *sp, real_T varargin_1);
static const mxArray *message(const emlrtStack *sp, const mxArray *b,
  emlrtMCInfo *location);

/* Function Definitions */
static const mxArray *b_message(const emlrtStack *sp, const mxArray *b, const
  mxArray *c, const mxArray *d, emlrtMCInfo *location)
{
  const mxArray *pArrays[3];
  const mxArray *m5;
  pArrays[0] = b;
  pArrays[1] = c;
  pArrays[2] = d;
  return emlrtCallMATLABR2012b(sp, 1, &m5, 3, pArrays, "message", true, location);
}

static void eml_assert_valid_size_arg(const emlrtStack *sp, real_T varargin_1)
{
  boolean_T p;
  boolean_T guard1 = false;
  const mxArray *y;
  static const int32_T iv8[2] = { 1, 28 };

  const mxArray *m1;
  char_T cv6[28];
  int32_T i;
  static const char_T cv7[28] = { 'C', 'o', 'd', 'e', 'r', ':', 'M', 'A', 'T',
    'L', 'A', 'B', ':', 'N', 'o', 'n', 'I', 'n', 't', 'e', 'g', 'e', 'r', 'I',
    'n', 'p', 'u', 't' };

  const mxArray *b_y;
  const mxArray *c_y;
  real_T b_varargin_1;
  const mxArray *d_y;
  static const int32_T iv9[2] = { 1, 21 };

  char_T cv8[21];
  static const char_T cv9[21] = { 'C', 'o', 'd', 'e', 'r', ':', 'M', 'A', 'T',
    'L', 'A', 'B', ':', 'p', 'm', 'a', 'x', 's', 'i', 'z', 'e' };

  emlrtStack st;
  emlrtStack b_st;
  st.prev = sp;
  st.tls = sp->tls;
  b_st.prev = sp;
  b_st.tls = sp->tls;
  if ((varargin_1 != muDoubleScalarFloor(varargin_1)) || muDoubleScalarIsInf
      (varargin_1)) {
    p = false;
  } else {
    p = true;
  }

  guard1 = false;
  if (p) {
    if ((-2.147483648E+9 > varargin_1) || (2.147483647E+9 < varargin_1)) {
      p = false;
    } else {
      p = true;
    }

    if (p) {
      p = true;
    } else {
      guard1 = true;
    }
  } else {
    guard1 = true;
  }

  if (guard1) {
    p = false;
  }

  if (p) {
  } else {
    y = NULL;
    m1 = emlrtCreateCharArray(2, iv8);
    for (i = 0; i < 28; i++) {
      cv6[i] = cv7[i];
    }

    emlrtInitCharArrayR2013a(sp, 28, m1, cv6);
    emlrtAssign(&y, m1);
    b_y = NULL;
    m1 = emlrtCreateNumericMatrix(1, 1, mxINT32_CLASS, mxREAL);
    *(int32_T *)mxGetData(m1) = MIN_int32_T;
    emlrtAssign(&b_y, m1);
    c_y = NULL;
    m1 = emlrtCreateNumericMatrix(1, 1, mxINT32_CLASS, mxREAL);
    *(int32_T *)mxGetData(m1) = MAX_int32_T;
    emlrtAssign(&c_y, m1);
    st.site = &s_emlrtRSI;
    b_st.site = &cb_emlrtRSI;
    error(&st, b_message(&b_st, y, b_y, c_y, (emlrtMCInfo *)&c_emlrtMCI),
          (emlrtMCInfo *)&d_emlrtMCI);
  }

  if (varargin_1 <= 0.0) {
    b_varargin_1 = 0.0;
  } else {
    b_varargin_1 = varargin_1;
  }

  if (2.147483647E+9 >= b_varargin_1) {
  } else {
    d_y = NULL;
    m1 = emlrtCreateCharArray(2, iv9);
    for (i = 0; i < 21; i++) {
      cv8[i] = cv9[i];
    }

    emlrtInitCharArrayR2013a(sp, 21, m1, cv8);
    emlrtAssign(&d_y, m1);
    st.site = &r_emlrtRSI;
    b_st.site = &w_emlrtRSI;
    error(&st, message(&b_st, d_y, (emlrtMCInfo *)&e_emlrtMCI), (emlrtMCInfo *)
          &f_emlrtMCI);
  }
}

static const mxArray *message(const emlrtStack *sp, const mxArray *b,
  emlrtMCInfo *location)
{
  const mxArray *pArray;
  const mxArray *m4;
  pArray = b;
  return emlrtCallMATLABR2012b(sp, 1, &m4, 1, &pArray, "message", true, location);
}

real_T applyKerasTrainedModel(const emlrtStack *sp, const emxArray_real_T
  *test_data, const emxArray_real_T *weight, const emxArray_real_T *NodesArray)
{
  real_T test_results;
  emxArray_real_T *temp;
  int32_T i0;
  int32_T maxdimlen;
  real_T alpha1;
  int32_T i1;
  real_T beta1;
  int32_T i2;
  int32_T i3;
  int32_T sz[2];
  emxArray_real_T *a;
  int32_T NodesArray_idx_1;
  const mxArray *y;
  static const int32_T iv0[2] = { 1, 40 };

  const mxArray *m0;
  char_T cv0[40];
  int32_T i;
  static const char_T cv1[40] = { 'C', 'o', 'd', 'e', 'r', ':', 'M', 'A', 'T',
    'L', 'A', 'B', ':', 'g', 'e', 't', 'R', 'e', 's', 'h', 'a', 'p', 'e', 'D',
    'i', 'm', 's', '_', 'n', 'o', 't', 'S', 'a', 'm', 'e', 'N', 'u', 'm', 'e',
    'l' };

  boolean_T b0;
  const mxArray *b_y;
  static const int32_T iv1[2] = { 1, 45 };

  char_T cv2[45];
  static const char_T cv3[45] = { 'C', 'o', 'd', 'e', 'r', ':', 't', 'o', 'o',
    'l', 'b', 'o', 'x', ':', 'm', 't', 'i', 'm', 'e', 's', '_', 'n', 'o', 'D',
    'y', 'n', 'a', 'm', 'i', 'c', 'S', 'c', 'a', 'l', 'a', 'r', 'E', 'x', 'p',
    'a', 'n', 's', 'i', 'o', 'n' };

  const mxArray *c_y;
  static const int32_T iv2[2] = { 1, 21 };

  char_T cv4[21];
  static const char_T cv5[21] = { 'C', 'o', 'd', 'e', 'r', ':', 'M', 'A', 'T',
    'L', 'A', 'B', ':', 'i', 'n', 'n', 'e', 'r', 'd', 'i', 'm' };

  emxArray_real_T *C;
  emxArray_real_T *r0;
  uint32_T varargin_1_idx_0;
  char_T TRANSB;
  char_T TRANSA;
  ptrdiff_t m_t;
  ptrdiff_t n_t;
  ptrdiff_t k_t;
  ptrdiff_t lda_t;
  ptrdiff_t ldb_t;
  ptrdiff_t ldc_t;
  double * alpha1_t;
  double * Aia0_t;
  double * Bib0_t;
  double * beta1_t;
  double * Cic0_t;
  emxArray_real_T *b_C;
  real_T cursor;
  emxArray_real_T *c_C;
  int32_T i4;
  int32_T nx;
  int32_T b_sz[2];
  const mxArray *d_y;
  static const int32_T iv3[2] = { 1, 40 };

  boolean_T b1;
  const mxArray *e_y;
  static const int32_T iv4[2] = { 1, 45 };

  const mxArray *f_y;
  static const int32_T iv5[2] = { 1, 21 };

  emxArray_real_T *b_a;
  const mxArray *g_y;
  static const int32_T iv6[2] = { 1, 45 };

  const mxArray *h_y;
  static const int32_T iv7[2] = { 1, 21 };

  emlrtStack st;
  emlrtStack b_st;
  emlrtStack c_st;
  emlrtStack d_st;
  emlrtStack e_st;
  emlrtStack f_st;
  emlrtStack g_st;
  st.prev = sp;
  st.tls = sp->tls;
  b_st.prev = &st;
  b_st.tls = st.tls;
  c_st.prev = &b_st;
  c_st.tls = b_st.tls;
  d_st.prev = &st;
  d_st.tls = st.tls;
  e_st.prev = &b_st;
  e_st.tls = b_st.tls;
  f_st.prev = &c_st;
  f_st.tls = c_st.tls;
  g_st.prev = &f_st;
  g_st.tls = f_st.tls;
  emlrtHeapReferenceStackEnterFcnR2012b(sp);
  emxInit_real_T(sp, &temp, 1, &c_emlrtRTEI, true);

  /* -------------------------------------------------------------------------- */
  /*  [Output] = applyKerasTrainedModel(test_data,net) */
  /*  */
  /*  applying Keras trained neural network to fit input where: */
  /*    -net: Keras Neural Network Object as numpy array (2 layers) */
  /*    -Input: Testing Input */
  /*   */
  /*  based on Keras with Tensorflow, python 3.6, all activation function uses */
  /*  sigmoid (copy sigmoid.m together with this file for use elsewhere) */
  /* -------------------------------------------------------------------------- */
  i0 = temp->size[0];
  temp->size[0] = test_data->size[1];
  emxEnsureCapacity(sp, (emxArray__common *)temp, i0, (int32_T)sizeof(real_T),
                    &emlrtRTEI);
  maxdimlen = test_data->size[1];
  for (i0 = 0; i0 < maxdimlen; i0++) {
    temp->data[i0] = test_data->data[test_data->size[0] * i0];
  }

  i0 = NodesArray->size[1];
  emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&emlrtBCI, sp);
  alpha1 = (1.0 + (real_T)test_data->size[1] * NodesArray->data[0]) - 1.0;
  if (1.0 > alpha1) {
    i0 = 0;
  } else {
    i0 = weight->size[1];
    emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&b_emlrtBCI, sp);
    i0 = weight->size[1];
    i1 = (int32_T)emlrtIntegerCheckFastR2012b(alpha1, (emlrtDCInfo *)&emlrtDCI,
      sp);
    i0 = emlrtDynamicBoundsCheckFastR2012b(i1, 1, i0, (emlrtBCInfo *)&b_emlrtBCI,
      sp);
  }

  i1 = NodesArray->size[1];
  emlrtDynamicBoundsCheckFastR2012b(1, 1, i1, (emlrtBCInfo *)&d_emlrtBCI, sp);
  alpha1 = 1.0 + (real_T)test_data->size[1] * NodesArray->data[0];
  i1 = NodesArray->size[1];
  emlrtDynamicBoundsCheckFastR2012b(1, 1, i1, (emlrtBCInfo *)&e_emlrtBCI, sp);
  i1 = NodesArray->size[1];
  emlrtDynamicBoundsCheckFastR2012b(1, 1, i1, (emlrtBCInfo *)&f_emlrtBCI, sp);
  beta1 = ((1.0 + (real_T)test_data->size[1] * NodesArray->data[0]) +
           NodesArray->data[0]) - 1.0;
  if (alpha1 > beta1) {
    i1 = 1;
    i2 = 1;
  } else {
    i1 = weight->size[1];
    i2 = (int32_T)emlrtIntegerCheckFastR2012b(alpha1, (emlrtDCInfo *)&b_emlrtDCI,
      sp);
    i1 = emlrtDynamicBoundsCheckFastR2012b(i2, 1, i1, (emlrtBCInfo *)&g_emlrtBCI,
      sp);
    i2 = weight->size[1];
    i3 = (int32_T)emlrtIntegerCheckFastR2012b(beta1, (emlrtDCInfo *)&b_emlrtDCI,
      sp);
    i2 = emlrtDynamicBoundsCheckFastR2012b(i3, 1, i2, (emlrtBCInfo *)&g_emlrtBCI,
      sp) + 1;
  }

  i3 = NodesArray->size[1];
  emlrtDynamicBoundsCheckFastR2012b(1, 1, i3, (emlrtBCInfo *)&c_emlrtBCI, sp);
  st.site = &emlrtRSI;
  b_st.site = &d_emlrtRSI;
  c_st.site = &g_emlrtRSI;
  eml_assert_valid_size_arg(&c_st, NodesArray->data[0]);
  c_st.site = &g_emlrtRSI;
  eml_assert_valid_size_arg(&c_st, (real_T)test_data->size[1]);
  sz[0] = (int32_T)NodesArray->data[0];
  sz[1] = test_data->size[1];
  maxdimlen = 1;
  if ((uint32_T)i0 > 1U) {
    maxdimlen = i0;
  }

  if (i0 < maxdimlen) {
  } else {
    maxdimlen = i0;
  }

  if (sz[0] > maxdimlen) {
    b_st.site = &e_emlrtRSI;
    eml_error(&b_st);
  }

  if (sz[1] > maxdimlen) {
    b_st.site = &e_emlrtRSI;
    eml_error(&b_st);
  }

  for (i3 = 0; i3 < 2; i3++) {
    emlrtNonNegativeCheckFastR2012b((real_T)sz[i3], (emlrtDCInfo *)&f_emlrtDCI,
      &st);
  }

  b_emxInit_real_T(&st, &a, 2, &emlrtRTEI, true);
  i3 = a->size[0] * a->size[1];
  a->size[0] = (int32_T)NodesArray->data[0];
  a->size[1] = test_data->size[1];
  emxEnsureCapacity(&st, (emxArray__common *)a, i3, (int32_T)sizeof(real_T),
                    &b_emlrtRTEI);
  maxdimlen = (int32_T)NodesArray->data[0];
  NodesArray_idx_1 = test_data->size[1];
  if (i0 == maxdimlen * NodesArray_idx_1) {
  } else {
    y = NULL;
    m0 = emlrtCreateCharArray(2, iv0);
    for (i = 0; i < 40; i++) {
      cv0[i] = cv1[i];
    }

    emlrtInitCharArrayR2013a(&st, 40, m0, cv0);
    emlrtAssign(&y, m0);
    b_st.site = &v_emlrtRSI;
    d_st.site = &ab_emlrtRSI;
    error(&b_st, message(&d_st, y, (emlrtMCInfo *)&emlrtMCI), (emlrtMCInfo *)
          &b_emlrtMCI);
  }

  b_st.site = &f_emlrtRSI;
  if (1 > i0) {
    b0 = false;
  } else {
    b0 = (i0 > 2147483646);
  }

  if (b0) {
    c_st.site = &h_emlrtRSI;
    check_forloop_overflow_error(&c_st);
  }

  for (maxdimlen = 0; maxdimlen + 1 <= i0; maxdimlen++) {
    a->data[maxdimlen] = weight->data[maxdimlen];
  }

  st.site = &emlrtRSI;
  b_st.site = &j_emlrtRSI;
  if (!(a->size[1] == temp->size[0])) {
    if (((a->size[0] == 1) && (a->size[1] == 1)) || (temp->size[0] == 1)) {
      b_y = NULL;
      m0 = emlrtCreateCharArray(2, iv1);
      for (i = 0; i < 45; i++) {
        cv2[i] = cv3[i];
      }

      emlrtInitCharArrayR2013a(&b_st, 45, m0, cv2);
      emlrtAssign(&b_y, m0);
      c_st.site = &t_emlrtRSI;
      e_st.site = &x_emlrtRSI;
      error(&c_st, message(&e_st, b_y, (emlrtMCInfo *)&i_emlrtMCI), (emlrtMCInfo
             *)&j_emlrtMCI);
    } else {
      c_y = NULL;
      m0 = emlrtCreateCharArray(2, iv2);
      for (i = 0; i < 21; i++) {
        cv4[i] = cv5[i];
      }

      emlrtInitCharArrayR2013a(&b_st, 21, m0, cv4);
      emlrtAssign(&c_y, m0);
      c_st.site = &u_emlrtRSI;
      e_st.site = &y_emlrtRSI;
      error(&c_st, message(&e_st, c_y, (emlrtMCInfo *)&k_emlrtMCI), (emlrtMCInfo
             *)&l_emlrtMCI);
    }
  }

  emxInit_real_T(&st, &C, 1, &emlrtRTEI, true);
  emxInit_real_T(&st, &r0, 1, &emlrtRTEI, true);
  if ((a->size[1] == 1) || (temp->size[0] == 1)) {
    i0 = C->size[0];
    C->size[0] = a->size[0];
    emxEnsureCapacity(&st, (emxArray__common *)C, i0, (int32_T)sizeof(real_T),
                      &emlrtRTEI);
    maxdimlen = a->size[0];
    for (i0 = 0; i0 < maxdimlen; i0++) {
      C->data[i0] = 0.0;
      NodesArray_idx_1 = a->size[1];
      for (i3 = 0; i3 < NodesArray_idx_1; i3++) {
        C->data[i0] += a->data[i0 + a->size[0] * i3] * temp->data[i3];
      }
    }
  } else {
    varargin_1_idx_0 = (uint32_T)a->size[0];
    i0 = r0->size[0];
    r0->size[0] = (int32_T)varargin_1_idx_0;
    emxEnsureCapacity(&st, (emxArray__common *)r0, i0, (int32_T)sizeof(real_T),
                      &emlrtRTEI);
    maxdimlen = (int32_T)varargin_1_idx_0;
    for (i0 = 0; i0 < maxdimlen; i0++) {
      r0->data[i0] = 0.0;
    }

    b_st.site = &i_emlrtRSI;
    c_st.site = &k_emlrtRSI;
    i0 = C->size[0];
    C->size[0] = (int32_T)varargin_1_idx_0;
    emxEnsureCapacity(&c_st, (emxArray__common *)C, i0, (int32_T)sizeof(real_T),
                      &emlrtRTEI);
    maxdimlen = (int32_T)varargin_1_idx_0;
    for (i0 = 0; i0 < maxdimlen; i0++) {
      C->data[i0] = 0.0;
    }

    if ((a->size[0] < 1) || (a->size[1] < 1)) {
    } else {
      f_st.site = &l_emlrtRSI;
      alpha1 = 1.0;
      beta1 = 0.0;
      TRANSB = 'N';
      TRANSA = 'N';
      g_st.site = &l_emlrtRSI;
      m_t = (ptrdiff_t)(a->size[0]);
      g_st.site = &l_emlrtRSI;
      n_t = (ptrdiff_t)(1);
      g_st.site = &l_emlrtRSI;
      k_t = (ptrdiff_t)(a->size[1]);
      g_st.site = &l_emlrtRSI;
      lda_t = (ptrdiff_t)(a->size[0]);
      g_st.site = &l_emlrtRSI;
      ldb_t = (ptrdiff_t)(a->size[1]);
      g_st.site = &l_emlrtRSI;
      ldc_t = (ptrdiff_t)(a->size[0]);
      alpha1_t = (double *)(&alpha1);
      i0 = a->size[0] * a->size[1];
      emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&p_emlrtBCI,
        &f_st);
      Aia0_t = (double *)(&a->data[0]);
      i0 = temp->size[0];
      emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&p_emlrtBCI,
        &f_st);
      Bib0_t = (double *)(&temp->data[0]);
      beta1_t = (double *)(&beta1);
      i0 = r0->size[0];
      emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&p_emlrtBCI,
        &f_st);
      Cic0_t = (double *)(&C->data[0]);
      dgemm(&TRANSA, &TRANSB, &m_t, &n_t, &k_t, alpha1_t, Aia0_t, &lda_t, Bib0_t,
            &ldb_t, beta1_t, Cic0_t, &ldc_t);
    }
  }

  emxInit_real_T(&st, &b_C, 1, &emlrtRTEI, true);
  i0 = C->size[0];
  i2 -= i1;
  emlrtSizeEqCheck1DFastR2012b(i0, i2, (emlrtECInfo *)&emlrtECI, sp);
  i0 = b_C->size[0];
  b_C->size[0] = C->size[0];
  emxEnsureCapacity(sp, (emxArray__common *)b_C, i0, (int32_T)sizeof(real_T),
                    &emlrtRTEI);
  maxdimlen = C->size[0];
  for (i0 = 0; i0 < maxdimlen; i0++) {
    b_C->data[i0] = C->data[i0] + weight->data[(i1 + i0) - 1];
  }

  sigmoid(sp, b_C, temp);
  i0 = NodesArray->size[1];
  emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&h_emlrtBCI, sp);
  i0 = NodesArray->size[1];
  emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&i_emlrtBCI, sp);
  cursor = (1.0 + (real_T)test_data->size[1] * NodesArray->data[0]) +
    NodesArray->data[0];
  i = 1;
  emxFree_real_T(&b_C);
  emxInit_real_T(sp, &c_C, 1, &emlrtRTEI, true);
  while (i - 1 <= NodesArray->size[1] - 2) {
    i0 = NodesArray->size[1];
    i1 = NodesArray->size[1];
    i2 = 1 + i;
    alpha1 = (cursor + NodesArray->data[emlrtDynamicBoundsCheckFastR2012b(i, 1,
               i0, (emlrtBCInfo *)&s_emlrtBCI, sp) - 1] * NodesArray->
              data[emlrtDynamicBoundsCheckFastR2012b(i2, 1, i1, (emlrtBCInfo *)
               &t_emlrtBCI, sp) - 1]) - 1.0;
    if (cursor > alpha1) {
      i0 = 1;
      i1 = 1;
    } else {
      i0 = weight->size[1];
      i1 = (int32_T)emlrtIntegerCheckFastR2012b(cursor, (emlrtDCInfo *)
        &c_emlrtDCI, sp);
      i0 = emlrtDynamicBoundsCheckFastR2012b(i1, 1, i0, (emlrtBCInfo *)
        &j_emlrtBCI, sp);
      i1 = weight->size[1];
      i2 = (int32_T)emlrtIntegerCheckFastR2012b(alpha1, (emlrtDCInfo *)
        &c_emlrtDCI, sp);
      i1 = emlrtDynamicBoundsCheckFastR2012b(i2, 1, i1, (emlrtBCInfo *)
        &j_emlrtBCI, sp) + 1;
    }

    i2 = NodesArray->size[1];
    i3 = NodesArray->size[1];
    i4 = 1 + i;
    alpha1 = cursor + NodesArray->data[emlrtDynamicBoundsCheckFastR2012b(i, 1,
      i2, (emlrtBCInfo *)&u_emlrtBCI, sp) - 1] * NodesArray->
      data[emlrtDynamicBoundsCheckFastR2012b(i4, 1, i3, (emlrtBCInfo *)
      &v_emlrtBCI, sp) - 1];
    i2 = NodesArray->size[1];
    i3 = NodesArray->size[1];
    i4 = 1 + i;
    maxdimlen = NodesArray->size[1];
    NodesArray_idx_1 = 1 + i;
    beta1 = ((cursor + NodesArray->data[emlrtDynamicBoundsCheckFastR2012b(i, 1,
               i2, (emlrtBCInfo *)&w_emlrtBCI, sp) - 1] * NodesArray->
              data[emlrtDynamicBoundsCheckFastR2012b(i4, 1, i3, (emlrtBCInfo *)
               &x_emlrtBCI, sp) - 1]) + NodesArray->
             data[emlrtDynamicBoundsCheckFastR2012b(NodesArray_idx_1, 1,
              maxdimlen, (emlrtBCInfo *)&y_emlrtBCI, sp) - 1]) - 1.0;
    if (alpha1 > beta1) {
      i2 = 1;
      i3 = 1;
    } else {
      i2 = weight->size[1];
      i3 = (int32_T)emlrtIntegerCheckFastR2012b(alpha1, (emlrtDCInfo *)
        &d_emlrtDCI, sp);
      i2 = emlrtDynamicBoundsCheckFastR2012b(i3, 1, i2, (emlrtBCInfo *)
        &m_emlrtBCI, sp);
      i3 = weight->size[1];
      i4 = (int32_T)emlrtIntegerCheckFastR2012b(beta1, (emlrtDCInfo *)
        &d_emlrtDCI, sp);
      i3 = emlrtDynamicBoundsCheckFastR2012b(i4, 1, i3, (emlrtBCInfo *)
        &m_emlrtBCI, sp) + 1;
    }

    st.site = &b_emlrtRSI;
    i4 = NodesArray->size[1];
    maxdimlen = (int32_T)(2.0 + (real_T)(i - 1));
    emlrtDynamicBoundsCheckFastR2012b(maxdimlen, 1, i4, (emlrtBCInfo *)
      &k_emlrtBCI, &st);
    i4 = NodesArray->size[1];
    maxdimlen = (int32_T)((2.0 + (real_T)(i - 1)) - 1.0);
    emlrtDynamicBoundsCheckFastR2012b(maxdimlen, 1, i4, (emlrtBCInfo *)
      &l_emlrtBCI, &st);
    nx = i1 - i0;
    b_st.site = &d_emlrtRSI;
    c_st.site = &g_emlrtRSI;
    eml_assert_valid_size_arg(&c_st, NodesArray->data[i]);
    c_st.site = &g_emlrtRSI;
    eml_assert_valid_size_arg(&c_st, NodesArray->data[i - 1]);
    b_sz[0] = (int32_T)NodesArray->data[i];
    b_sz[1] = (int32_T)NodesArray->data[i - 1];
    varargin_1_idx_0 = (uint32_T)(i1 - i0);
    maxdimlen = 1;
    if (varargin_1_idx_0 > 1U) {
      maxdimlen = (int32_T)varargin_1_idx_0;
    }

    if (nx < maxdimlen) {
    } else {
      maxdimlen = i1 - i0;
    }

    if (b_sz[0] > maxdimlen) {
      b_st.site = &e_emlrtRSI;
      eml_error(&b_st);
    }

    if (b_sz[1] > maxdimlen) {
      b_st.site = &e_emlrtRSI;
      eml_error(&b_st);
    }

    for (i4 = 0; i4 < 2; i4++) {
      emlrtNonNegativeCheckFastR2012b((real_T)b_sz[i4], (emlrtDCInfo *)
        &f_emlrtDCI, &st);
    }

    i4 = a->size[0] * a->size[1];
    a->size[0] = (int32_T)NodesArray->data[i];
    a->size[1] = (int32_T)NodesArray->data[i - 1];
    emxEnsureCapacity(&st, (emxArray__common *)a, i4, (int32_T)sizeof(real_T),
                      &b_emlrtRTEI);
    maxdimlen = (int32_T)NodesArray->data[i];
    NodesArray_idx_1 = (int32_T)NodesArray->data[i - 1];
    if (nx == maxdimlen * NodesArray_idx_1) {
    } else {
      d_y = NULL;
      m0 = emlrtCreateCharArray(2, iv3);
      for (maxdimlen = 0; maxdimlen < 40; maxdimlen++) {
        cv0[maxdimlen] = cv1[maxdimlen];
      }

      emlrtInitCharArrayR2013a(&st, 40, m0, cv0);
      emlrtAssign(&d_y, m0);
      b_st.site = &v_emlrtRSI;
      d_st.site = &ab_emlrtRSI;
      error(&b_st, message(&d_st, d_y, (emlrtMCInfo *)&emlrtMCI), (emlrtMCInfo *)
            &b_emlrtMCI);
    }

    b_st.site = &f_emlrtRSI;
    if (1 > i1 - i0) {
      b1 = false;
    } else {
      b1 = (i1 - i0 > 2147483646);
    }

    if (b1) {
      c_st.site = &h_emlrtRSI;
      check_forloop_overflow_error(&c_st);
    }

    for (maxdimlen = -1; maxdimlen + 2 <= i1 - i0; maxdimlen++) {
      a->data[maxdimlen + 1] = weight->data[i0 + maxdimlen];
    }

    st.site = &b_emlrtRSI;
    b_st.site = &j_emlrtRSI;
    if (!(a->size[1] == temp->size[0])) {
      if (((a->size[0] == 1) && (a->size[1] == 1)) || (temp->size[0] == 1)) {
        e_y = NULL;
        m0 = emlrtCreateCharArray(2, iv4);
        for (maxdimlen = 0; maxdimlen < 45; maxdimlen++) {
          cv2[maxdimlen] = cv3[maxdimlen];
        }

        emlrtInitCharArrayR2013a(&b_st, 45, m0, cv2);
        emlrtAssign(&e_y, m0);
        c_st.site = &t_emlrtRSI;
        e_st.site = &x_emlrtRSI;
        error(&c_st, message(&e_st, e_y, (emlrtMCInfo *)&i_emlrtMCI),
              (emlrtMCInfo *)&j_emlrtMCI);
      } else {
        f_y = NULL;
        m0 = emlrtCreateCharArray(2, iv5);
        for (maxdimlen = 0; maxdimlen < 21; maxdimlen++) {
          cv4[maxdimlen] = cv5[maxdimlen];
        }

        emlrtInitCharArrayR2013a(&b_st, 21, m0, cv4);
        emlrtAssign(&f_y, m0);
        c_st.site = &u_emlrtRSI;
        e_st.site = &y_emlrtRSI;
        error(&c_st, message(&e_st, f_y, (emlrtMCInfo *)&k_emlrtMCI),
              (emlrtMCInfo *)&l_emlrtMCI);
      }
    }

    if ((a->size[1] == 1) || (temp->size[0] == 1)) {
      i0 = C->size[0];
      C->size[0] = a->size[0];
      emxEnsureCapacity(&st, (emxArray__common *)C, i0, (int32_T)sizeof(real_T),
                        &emlrtRTEI);
      maxdimlen = a->size[0];
      for (i0 = 0; i0 < maxdimlen; i0++) {
        C->data[i0] = 0.0;
        NodesArray_idx_1 = a->size[1];
        for (i1 = 0; i1 < NodesArray_idx_1; i1++) {
          C->data[i0] += a->data[i0 + a->size[0] * i1] * temp->data[i1];
        }
      }
    } else {
      varargin_1_idx_0 = (uint32_T)a->size[0];
      i0 = r0->size[0];
      r0->size[0] = (int32_T)varargin_1_idx_0;
      emxEnsureCapacity(&st, (emxArray__common *)r0, i0, (int32_T)sizeof(real_T),
                        &emlrtRTEI);
      maxdimlen = (int32_T)varargin_1_idx_0;
      for (i0 = 0; i0 < maxdimlen; i0++) {
        r0->data[i0] = 0.0;
      }

      b_st.site = &i_emlrtRSI;
      c_st.site = &k_emlrtRSI;
      i0 = C->size[0];
      C->size[0] = (int32_T)varargin_1_idx_0;
      emxEnsureCapacity(&c_st, (emxArray__common *)C, i0, (int32_T)sizeof(real_T),
                        &emlrtRTEI);
      maxdimlen = (int32_T)varargin_1_idx_0;
      for (i0 = 0; i0 < maxdimlen; i0++) {
        C->data[i0] = 0.0;
      }

      if ((a->size[0] < 1) || (a->size[1] < 1)) {
      } else {
        f_st.site = &l_emlrtRSI;
        alpha1 = 1.0;
        beta1 = 0.0;
        TRANSB = 'N';
        TRANSA = 'N';
        g_st.site = &l_emlrtRSI;
        m_t = (ptrdiff_t)(a->size[0]);
        g_st.site = &l_emlrtRSI;
        n_t = (ptrdiff_t)(1);
        g_st.site = &l_emlrtRSI;
        k_t = (ptrdiff_t)(a->size[1]);
        g_st.site = &l_emlrtRSI;
        lda_t = (ptrdiff_t)(a->size[0]);
        g_st.site = &l_emlrtRSI;
        ldb_t = (ptrdiff_t)(a->size[1]);
        g_st.site = &l_emlrtRSI;
        ldc_t = (ptrdiff_t)(a->size[0]);
        alpha1_t = (double *)(&alpha1);
        i0 = a->size[0] * a->size[1];
        emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&p_emlrtBCI,
          &f_st);
        Aia0_t = (double *)(&a->data[0]);
        i0 = temp->size[0];
        emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&p_emlrtBCI,
          &f_st);
        Bib0_t = (double *)(&temp->data[0]);
        beta1_t = (double *)(&beta1);
        i0 = r0->size[0];
        emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&p_emlrtBCI,
          &f_st);
        Cic0_t = (double *)(&C->data[0]);
        dgemm(&TRANSA, &TRANSB, &m_t, &n_t, &k_t, alpha1_t, Aia0_t, &lda_t,
              Bib0_t, &ldb_t, beta1_t, Cic0_t, &ldc_t);
      }
    }

    i0 = C->size[0];
    i1 = i3 - i2;
    emlrtSizeEqCheck1DFastR2012b(i0, i1, (emlrtECInfo *)&b_emlrtECI, sp);
    i0 = c_C->size[0];
    c_C->size[0] = C->size[0];
    emxEnsureCapacity(sp, (emxArray__common *)c_C, i0, (int32_T)sizeof(real_T),
                      &emlrtRTEI);
    maxdimlen = C->size[0];
    for (i0 = 0; i0 < maxdimlen; i0++) {
      c_C->data[i0] = C->data[i0] + weight->data[(i2 + i0) - 1];
    }

    sigmoid(sp, c_C, temp);
    i0 = NodesArray->size[1];
    i1 = NodesArray->size[1];
    i2 = 1 + i;
    cursor += NodesArray->data[emlrtDynamicBoundsCheckFastR2012b(i, 1, i0,
      (emlrtBCInfo *)&ab_emlrtBCI, sp) - 1] * NodesArray->
      data[emlrtDynamicBoundsCheckFastR2012b(i2, 1, i1, (emlrtBCInfo *)
      &bb_emlrtBCI, sp) - 1];
    i0 = NodesArray->size[1];
    i1 = 1 + i;
    cursor += NodesArray->data[emlrtDynamicBoundsCheckFastR2012b(i1, 1, i0,
      (emlrtBCInfo *)&cb_emlrtBCI, sp) - 1];
    i++;
    emlrtBreakCheckFastR2012b((const volatile char_T *)
      emlrtBreakCheckR2012bFlagVar, sp);
  }

  emxFree_real_T(&c_C);
  emxFree_real_T(&r0);
  emxFree_real_T(&a);
  emxFree_real_T(&C);
  i0 = NodesArray->size[1];
  i1 = NodesArray->size[1];
  alpha1 = (cursor + NodesArray->data[emlrtDynamicBoundsCheckFastR2012b(i1, 1,
             i0, (emlrtBCInfo *)&r_emlrtBCI, sp) - 1]) - 1.0;
  if (cursor > alpha1) {
    i0 = 1;
    i1 = 1;
  } else {
    i0 = weight->size[1];
    i1 = (int32_T)emlrtIntegerCheckFastR2012b(cursor, (emlrtDCInfo *)&e_emlrtDCI,
      sp);
    i0 = emlrtDynamicBoundsCheckFastR2012b(i1, 1, i0, (emlrtBCInfo *)&n_emlrtBCI,
      sp);
    i1 = weight->size[1];
    i2 = (int32_T)emlrtIntegerCheckFastR2012b(alpha1, (emlrtDCInfo *)&e_emlrtDCI,
      sp);
    i1 = emlrtDynamicBoundsCheckFastR2012b(i2, 1, i1, (emlrtBCInfo *)&n_emlrtBCI,
      sp) + 1;
  }

  b_emxInit_real_T(sp, &b_a, 2, &emlrtRTEI, true);
  st.site = &c_emlrtRSI;
  i2 = b_a->size[0] * b_a->size[1];
  b_a->size[0] = 1;
  b_a->size[1] = i1 - i0;
  emxEnsureCapacity(&st, (emxArray__common *)b_a, i2, (int32_T)sizeof(real_T),
                    &emlrtRTEI);
  maxdimlen = i1 - i0;
  for (i2 = 0; i2 < maxdimlen; i2++) {
    b_a->data[b_a->size[0] * i2] = weight->data[(i0 + i2) - 1];
  }

  b_st.site = &j_emlrtRSI;
  if (!(i1 - i0 == temp->size[0])) {
    if ((i1 - i0 == 1) || (temp->size[0] == 1)) {
      g_y = NULL;
      m0 = emlrtCreateCharArray(2, iv6);
      for (i = 0; i < 45; i++) {
        cv2[i] = cv3[i];
      }

      emlrtInitCharArrayR2013a(&b_st, 45, m0, cv2);
      emlrtAssign(&g_y, m0);
      c_st.site = &t_emlrtRSI;
      e_st.site = &x_emlrtRSI;
      error(&c_st, message(&e_st, g_y, (emlrtMCInfo *)&i_emlrtMCI), (emlrtMCInfo
             *)&j_emlrtMCI);
    } else {
      h_y = NULL;
      m0 = emlrtCreateCharArray(2, iv7);
      for (i = 0; i < 21; i++) {
        cv4[i] = cv5[i];
      }

      emlrtInitCharArrayR2013a(&b_st, 21, m0, cv4);
      emlrtAssign(&h_y, m0);
      c_st.site = &u_emlrtRSI;
      e_st.site = &y_emlrtRSI;
      error(&c_st, message(&e_st, h_y, (emlrtMCInfo *)&k_emlrtMCI), (emlrtMCInfo
             *)&l_emlrtMCI);
    }
  }

  if ((i1 - i0 == 1) || (temp->size[0] == 1)) {
    alpha1 = 0.0;
    for (i0 = 0; i0 < b_a->size[1]; i0++) {
      alpha1 += b_a->data[b_a->size[0] * i0] * temp->data[i0];
    }
  } else {
    b_st.site = &m_emlrtRSI;
    c_st.site = &n_emlrtRSI;
    f_st.site = &o_emlrtRSI;
    if (i1 - i0 < 1) {
      alpha1 = 0.0;
    } else {
      g_st.site = &p_emlrtRSI;
      n_t = (ptrdiff_t)(i1 - i0);
      m_t = (ptrdiff_t)(1);
      k_t = (ptrdiff_t)(1);
      i0 = i1 - i0;
      emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&q_emlrtBCI,
        &g_st);
      alpha1_t = (double *)(&b_a->data[0]);
      i0 = temp->size[0];
      emlrtDynamicBoundsCheckFastR2012b(1, 1, i0, (emlrtBCInfo *)&q_emlrtBCI,
        &g_st);
      Aia0_t = (double *)(&temp->data[0]);
      alpha1 = ddot(&n_t, alpha1_t, &m_t, Aia0_t, &k_t);
    }
  }

  emxFree_real_T(&b_a);
  emxFree_real_T(&temp);
  i0 = weight->size[1];
  i1 = weight->size[1];
  emlrtDynamicBoundsCheckFastR2012b(i1, 1, i0, (emlrtBCInfo *)&o_emlrtBCI, sp);
  test_results = 1.0 / (1.0 + muDoubleScalarExp(-(alpha1 + weight->data
    [weight->size[1] - 1])));
  emlrtHeapReferenceStackLeaveFcnR2012b(sp);
  return test_results;
}

/* End of code generation (applyKerasTrainedModel.cpp) */
