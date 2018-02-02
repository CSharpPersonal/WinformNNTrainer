/*
 * eml_int_forloop_overflow_check.cpp
 *
 * Code generation for function 'eml_int_forloop_overflow_check'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "eml_int_forloop_overflow_check.h"
#include "applyKerasTrainedModel_mexutil.h"

/* Variable Definitions */
static emlrtMCInfo g_emlrtMCI = { 75, 9, "eml_int_forloop_overflow_check",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_int_forloop_overflow_check.m"
};

static emlrtMCInfo h_emlrtMCI = { 74, 15, "eml_int_forloop_overflow_check",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_int_forloop_overflow_check.m"
};

static emlrtRSInfo q_emlrtRSI = { 74, "eml_int_forloop_overflow_check",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_int_forloop_overflow_check.m"
};

static emlrtRSInfo bb_emlrtRSI = { 75, "eml_int_forloop_overflow_check",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_int_forloop_overflow_check.m"
};

/* Function Declarations */
static const mxArray *c_message(const emlrtStack *sp, const mxArray *b, const
  mxArray *c, emlrtMCInfo *location);

/* Function Definitions */
static const mxArray *c_message(const emlrtStack *sp, const mxArray *b, const
  mxArray *c, emlrtMCInfo *location)
{
  const mxArray *pArrays[2];
  const mxArray *m6;
  pArrays[0] = b;
  pArrays[1] = c;
  return emlrtCallMATLABR2012b(sp, 1, &m6, 2, pArrays, "message", true, location);
}

void check_forloop_overflow_error(const emlrtStack *sp)
{
  const mxArray *y;
  static const int32_T iv10[2] = { 1, 34 };

  const mxArray *m2;
  char_T cv10[34];
  int32_T i;
  static const char_T cv11[34] = { 'C', 'o', 'd', 'e', 'r', ':', 't', 'o', 'o',
    'l', 'b', 'o', 'x', ':', 'i', 'n', 't', '_', 'f', 'o', 'r', 'l', 'o', 'o',
    'p', '_', 'o', 'v', 'e', 'r', 'f', 'l', 'o', 'w' };

  const mxArray *b_y;
  static const int32_T iv11[2] = { 1, 23 };

  char_T cv12[23];
  static const char_T cv13[23] = { 'c', 'o', 'd', 'e', 'r', '.', 'i', 'n', 't',
    'e', 'r', 'n', 'a', 'l', '.', 'i', 'n', 'd', 'e', 'x', 'I', 'n', 't' };

  emlrtStack st;
  emlrtStack b_st;
  st.prev = sp;
  st.tls = sp->tls;
  b_st.prev = sp;
  b_st.tls = sp->tls;
  y = NULL;
  m2 = emlrtCreateCharArray(2, iv10);
  for (i = 0; i < 34; i++) {
    cv10[i] = cv11[i];
  }

  emlrtInitCharArrayR2013a(sp, 34, m2, cv10);
  emlrtAssign(&y, m2);
  b_y = NULL;
  m2 = emlrtCreateCharArray(2, iv11);
  for (i = 0; i < 23; i++) {
    cv12[i] = cv13[i];
  }

  emlrtInitCharArrayR2013a(sp, 23, m2, cv12);
  emlrtAssign(&b_y, m2);
  st.site = &q_emlrtRSI;
  b_st.site = &bb_emlrtRSI;
  error(&st, c_message(&b_st, y, b_y, (emlrtMCInfo *)&g_emlrtMCI), (emlrtMCInfo *)
        &h_emlrtMCI);
}

/* End of code generation (eml_int_forloop_overflow_check.cpp) */