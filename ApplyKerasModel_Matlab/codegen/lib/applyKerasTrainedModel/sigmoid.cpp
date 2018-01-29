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

/* Function Definitions */
void sigmoid(const emxArray_real_T *t, emxArray_real_T *s)
{
  emxArray_real_T *x;
  int k;
  int loop_ub;
  emxInit_real_T(&x, 1);
  k = x->size[0];
  x->size[0] = t->size[0];
  emxEnsureCapacity((emxArray__common *)x, k, (int)sizeof(double));
  loop_ub = t->size[0];
  for (k = 0; k < loop_ub; k++) {
    x->data[k] = -t->data[k];
  }

  k = s->size[0];
  s->size[0] = x->size[0];
  emxEnsureCapacity((emxArray__common *)s, k, (int)sizeof(double));
  loop_ub = x->size[0];
  for (k = 0; k < loop_ub; k++) {
    s->data[k] = x->data[k];
  }

  for (k = 0; k < x->size[0]; k++) {
    s->data[k] = exp(s->data[k]);
  }

  emxFree_real_T(&x);
  k = s->size[0];
  emxEnsureCapacity((emxArray__common *)s, k, (int)sizeof(double));
  loop_ub = s->size[0];
  for (k = 0; k < loop_ub; k++) {
    s->data[k] = 1.0 / (1.0 + s->data[k]);
  }
}

/* End of code generation (sigmoid.cpp) */
