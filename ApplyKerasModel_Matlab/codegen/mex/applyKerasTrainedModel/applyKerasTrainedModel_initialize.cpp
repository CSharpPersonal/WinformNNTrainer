/*
 * applyKerasTrainedModel_initialize.cpp
 *
 * Code generation for function 'applyKerasTrainedModel_initialize'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "applyKerasTrainedModel_initialize.h"
#include "applyKerasTrainedModel_data.h"

/* Function Definitions */
void applyKerasTrainedModel_initialize(emlrtContext *aContext)
{
  emlrtStack st = { NULL, NULL, NULL };

  emlrtBreakCheckR2012bFlagVar = emlrtGetBreakCheckFlagAddressR2012b();
  emlrtCreateRootTLS(&emlrtRootTLSGlobal, aContext, NULL, 1);
  st.tls = emlrtRootTLSGlobal;
  emlrtClearAllocCountR2012b(&st, false, 0U, 0);
  emlrtEnterRtStackR2012b(&st);
  emlrtFirstTimeR2012b(emlrtRootTLSGlobal);
}

/* End of code generation (applyKerasTrainedModel_initialize.cpp) */
