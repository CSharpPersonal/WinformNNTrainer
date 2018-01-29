/*
 * applyKerasTrainedModel_terminate.cpp
 *
 * Code generation for function 'applyKerasTrainedModel_terminate'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "applyKerasTrainedModel_terminate.h"

/* Function Definitions */
void applyKerasTrainedModel_atexit()
{
  emlrtStack st = { NULL, NULL, NULL };

  emlrtCreateRootTLS(&emlrtRootTLSGlobal, &emlrtContextGlobal, NULL, 1);
  st.tls = emlrtRootTLSGlobal;
  emlrtEnterRtStackR2012b(&st);
  emlrtLeaveRtStackR2012b(&st);
  emlrtDestroyRootTLS(&emlrtRootTLSGlobal);
}

void applyKerasTrainedModel_terminate()
{
  emlrtStack st = { NULL, NULL, NULL };

  st.tls = emlrtRootTLSGlobal;
  emlrtLeaveRtStackR2012b(&st);
  emlrtDestroyRootTLS(&emlrtRootTLSGlobal);
}

/* End of code generation (applyKerasTrainedModel_terminate.cpp) */
