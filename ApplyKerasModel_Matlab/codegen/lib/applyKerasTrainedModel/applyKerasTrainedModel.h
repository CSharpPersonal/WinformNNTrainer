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
#include <stddef.h>
#include <stdlib.h>
#include <string.h>
#include "rtwtypes.h"
#include "applyKerasTrainedModel_types.h"

/* Function Declarations */
extern void applyKerasTrainedModel(const emxArray_real_T *test_data, const
  emxArray_real_T *weight, const emxArray_real_T *NodesArray, double
  *test_results, double *output_suppressor);

#endif

/* End of code generation (applyKerasTrainedModel.h) */
