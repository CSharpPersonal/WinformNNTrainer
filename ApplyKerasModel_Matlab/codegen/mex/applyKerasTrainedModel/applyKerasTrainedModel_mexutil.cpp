/*
 * applyKerasTrainedModel_mexutil.cpp
 *
 * Code generation for function 'applyKerasTrainedModel_mexutil'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "applyKerasTrainedModel_mexutil.h"

/* Function Definitions */
void error(const emlrtStack *sp, const mxArray *b, emlrtMCInfo *location)
{
  const mxArray *pArray;
  pArray = b;
  emlrtCallMATLABR2012b(sp, 0, NULL, 1, &pArray, "error", true, location);
}

/* End of code generation (applyKerasTrainedModel_mexutil.cpp) */
