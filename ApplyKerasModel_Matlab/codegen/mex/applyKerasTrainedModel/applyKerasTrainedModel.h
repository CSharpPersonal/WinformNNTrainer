/*
 * applyKerasTrainedModel.h
 *
 * Code generation for function 'applyKerasTrainedModel'
 *
 */

#ifndef __APPLYKERASTRAINEDMODEL_H__
#define __APPLYKERASTRAINEDMODEL_H__

/* Include files */
#include <math.h>
#include <stdlib.h>
#include <string.h>
#include "mwmathutil.h"
#include "tmwtypes.h"
#include "mex.h"
#include "emlrt.h"
#include "blas.h"
#include "rtwtypes.h"
#include "applyKerasTrainedModel_types.h"

/* Function Declarations */
extern real_T applyKerasTrainedModel(const emlrtStack *sp, const emxArray_real_T
  *test_data, const emxArray_real_T *weight, const emxArray_real_T *NodesArray);

#ifdef __WATCOMC__

#pragma aux applyKerasTrainedModel value [8087];

#endif
#endif

/* End of code generation (applyKerasTrainedModel.h) */
