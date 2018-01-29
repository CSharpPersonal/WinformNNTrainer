/*
 * _coder_applyKerasTrainedModel_api.cpp
 *
 * Code generation for function '_coder_applyKerasTrainedModel_api'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "_coder_applyKerasTrainedModel_api.h"
#include "applyKerasTrainedModel_emxutil.h"

/* Variable Definitions */
static emlrtRTEInfo e_emlrtRTEI = { 1, 1, "_coder_applyKerasTrainedModel_api",
  "" };

/* Function Declarations */
static void b_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u, const
  emlrtMsgIdentifier *parentId, emxArray_real_T *y);
static void c_emlrt_marshallIn(const emlrtStack *sp, const mxArray *src, const
  emlrtMsgIdentifier *msgId, emxArray_real_T *ret);
static void emlrt_marshallIn(const emlrtStack *sp, const mxArray *test_data,
  const char_T *identifier, emxArray_real_T *y);
static const mxArray *emlrt_marshallOut(const real_T u);

/* Function Definitions */
static void b_emlrt_marshallIn(const emlrtStack *sp, const mxArray *u, const
  emlrtMsgIdentifier *parentId, emxArray_real_T *y)
{
  c_emlrt_marshallIn(sp, emlrtAlias(u), parentId, y);
  emlrtDestroyArray(&u);
}

static void c_emlrt_marshallIn(const emlrtStack *sp, const mxArray *src, const
  emlrtMsgIdentifier *msgId, emxArray_real_T *ret)
{
  int32_T iv12[2];
  boolean_T bv0[2];
  int32_T i5;
  static const boolean_T bv1[2] = { false, true };

  int32_T iv13[2];
  for (i5 = 0; i5 < 2; i5++) {
    iv12[i5] = 1 + -2 * i5;
    bv0[i5] = bv1[i5];
  }

  emlrtCheckVsBuiltInR2012b(sp, msgId, src, "double", false, 2U, iv12, bv0, iv13);
  ret->size[0] = iv13[0];
  ret->size[1] = iv13[1];
  ret->allocatedSize = ret->size[0] * ret->size[1];
  ret->data = (real_T *)mxGetData(src);
  ret->canFreeData = false;
  emlrtDestroyArray(&src);
}

static void emlrt_marshallIn(const emlrtStack *sp, const mxArray *test_data,
  const char_T *identifier, emxArray_real_T *y)
{
  emlrtMsgIdentifier thisId;
  thisId.fIdentifier = identifier;
  thisId.fParent = NULL;
  b_emlrt_marshallIn(sp, emlrtAlias(test_data), &thisId, y);
  emlrtDestroyArray(&test_data);
}

static const mxArray *emlrt_marshallOut(const real_T u)
{
  const mxArray *y;
  const mxArray *m3;
  y = NULL;
  m3 = emlrtCreateDoubleScalar(u);
  emlrtAssign(&y, m3);
  return y;
}

void applyKerasTrainedModel_api(const mxArray * const prhs[3], const mxArray
  *plhs[1])
{
  emxArray_real_T *test_data;
  emxArray_real_T *weight;
  emxArray_real_T *NodesArray;
  real_T test_results;
  emlrtStack st = { NULL, NULL, NULL };

  st.tls = emlrtRootTLSGlobal;
  emlrtHeapReferenceStackEnterFcnR2012b(&st);
  b_emxInit_real_T(&st, &test_data, 2, &e_emlrtRTEI, true);
  b_emxInit_real_T(&st, &weight, 2, &e_emlrtRTEI, true);
  b_emxInit_real_T(&st, &NodesArray, 2, &e_emlrtRTEI, true);

  /* Marshall function inputs */
  emlrt_marshallIn(&st, emlrtAlias((const mxArray *)prhs[0]), "test_data",
                   test_data);
  emlrt_marshallIn(&st, emlrtAlias((const mxArray *)prhs[1]), "weight", weight);
  emlrt_marshallIn(&st, emlrtAlias((const mxArray *)prhs[2]), "NodesArray",
                   NodesArray);

  /* Invoke the target function */
  test_results = applyKerasTrainedModel(&st, test_data, weight, NodesArray);

  /* Marshall function outputs */
  plhs[0] = emlrt_marshallOut(test_results);
  NodesArray->canFreeData = false;
  emxFree_real_T(&NodesArray);
  weight->canFreeData = false;
  emxFree_real_T(&weight);
  test_data->canFreeData = false;
  emxFree_real_T(&test_data);
  emlrtHeapReferenceStackLeaveFcnR2012b(&st);
}

/* End of code generation (_coder_applyKerasTrainedModel_api.cpp) */
