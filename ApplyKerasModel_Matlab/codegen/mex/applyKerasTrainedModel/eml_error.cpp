/*
 * eml_error.cpp
 *
 * Code generation for function 'eml_error'
 *
 */

/* Include files */
#include "rt_nonfinite.h"
#include "applyKerasTrainedModel.h"
#include "eml_error.h"

/* Variable Definitions */
static emlrtRTEInfo f_emlrtRTEI = { 20, 5, "eml_error",
  "D:\\Derek\\program_files\\Matlab\\toolbox\\eml\\lib\\matlab\\eml\\eml_error.m"
};

/* Function Definitions */
void eml_error(const emlrtStack *sp)
{
  emlrtErrorWithMessageIdR2012b(sp, &f_emlrtRTEI,
    "Coder:toolbox:reshape_emptyReshapeLimit", 0);
}

/* End of code generation (eml_error.cpp) */
