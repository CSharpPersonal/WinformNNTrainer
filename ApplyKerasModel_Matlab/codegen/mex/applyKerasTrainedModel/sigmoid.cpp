/*
 * sigmoid.cpp
 *
 * Code generation for function 'sigmoid'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "sigmoid.h"
#include "applyKerasTrainedModel_emxutil.h"

/* Variable Definitions */
static emlrtRTEInfo d_emlrtRTEI = { 1, 16, "sigmoid",
  "D:\\Derek\\Software\\temp\\WinformNNTrainer\\ApplyKerasModel_Matlab\\sigmoid.m"
};

/* Function Definitions */
void sigmoid(const emlrtStack *sp, const emxArray_real_T *t, emxArray_real_T *s)
{
  emxArray_real_T *x;
  int32_T k;
  int32_T loop_ub;
  emlrtHeapReferenceStackEnterFcnR2012b(sp);
  emxInit_real_T(sp, &x, 1, &d_emlrtRTEI, true);
  k = x->size[0];
  x->size[0] = t->size[0];
  emxEnsureCapacity(sp, (emxArray__common *)x, k, (int32_T)sizeof(real_T),
                    &d_emlrtRTEI);
  loop_ub = t->size[0];
  for (k = 0; k < loop_ub; k++) {
    x->data[k] = -t->data[k];
  }

  k = s->size[0];
  s->size[0] = x->size[0];
  emxEnsureCapacity(sp, (emxArray__common *)s, k, (int32_T)sizeof(real_T),
                    &d_emlrtRTEI);
  loop_ub = x->size[0];
  for (k = 0; k < loop_ub; k++) {
    s->data[k] = x->data[k];
  }

  for (k = 0; k < x->size[0]; k++) {
    s->data[k] = muDoubleScalarExp(s->data[k]);
  }

  emxFree_real_T(&x);
  k = s->size[0];
  emxEnsureCapacity(sp, (emxArray__common *)s, k, (int32_T)sizeof(real_T),
                    &d_emlrtRTEI);
  loop_ub = s->size[0];
  for (k = 0; k < loop_ub; k++) {
    s->data[k] = 1.0 / (1.0 + s->data[k]);
  }

  emlrtHeapReferenceStackLeaveFcnR2012b(sp);
}

/* End of code generation (sigmoid.cpp) */
