/*
 * _coder_applyKerasTrainedModel_mex.cpp
 *
 * Code generation for function 'applyKerasTrainedModel'
 *
 */

/* Include files */
#include "mex.h"
#include "_coder_applyKerasTrainedModel_api.h"
#include "applyKerasTrainedModel_initialize.h"
#include "applyKerasTrainedModel_terminate.h"

/* Function Declarations */
static void applyKerasTrainedModel_mexFunction(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[]);

/* Variable Definitions */
emlrtContext emlrtContextGlobal = { true, false, EMLRT_VERSION_INFO, NULL, "applyKerasTrainedModel", NULL, false, {2045744189U,2170104910U,2743257031U,4284093946U}, NULL };
void *emlrtRootTLSGlobal = NULL;

/* Function Definitions */
static void applyKerasTrainedModel_mexFunction(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
  const mxArray *outputs[1];
  const mxArray *inputs[3];
  int n = 0;
  int nOutputs = (nlhs < 1 ? 1 : nlhs);
  int nInputs = nrhs;
  emlrtStack st = { NULL, NULL, NULL };
  /* Module initialization. */
  applyKerasTrainedModel_initialize(&emlrtContextGlobal);
  st.tls = emlrtRootTLSGlobal;
  /* Check for proper number of arguments. */
  if (nrhs != 3) {
    emlrtErrMsgIdAndTxt(&st, "EMLRT:runTime:WrongNumberOfInputs", 5, mxINT32_CLASS, 3, mxCHAR_CLASS, 22, "applyKerasTrainedModel");
  } else if (nlhs > 1) {
    emlrtErrMsgIdAndTxt(&st, "EMLRT:runTime:TooManyOutputArguments", 3, mxCHAR_CLASS, 22, "applyKerasTrainedModel");
  }
  /* Temporary copy for mex inputs. */
  for (n = 0; n < nInputs; ++n) {
    inputs[n] = prhs[n];
  }
  /* Call the function. */
  applyKerasTrainedModel_api(inputs, outputs);
  /* Copy over outputs to the caller. */
  for (n = 0; n < nOutputs; ++n) {
    plhs[n] = emlrtReturnArrayR2009a(outputs[n]);
  }
  /* Module finalization. */
  applyKerasTrainedModel_terminate();
}

void applyKerasTrainedModel_atexit_wrapper(void)
{
   applyKerasTrainedModel_atexit();
}

void mexFunction(int nlhs, mxArray *plhs[], int nrhs, const mxArray *prhs[])
{
  /* Initialize the memory manager. */
  mexAtExit(applyKerasTrainedModel_atexit_wrapper);
  /* Dispatch the entry-point. */
  applyKerasTrainedModel_mexFunction(nlhs, plhs, nrhs, prhs);
}
/* End of code generation (_coder_applyKerasTrainedModel_mex.cpp) */
