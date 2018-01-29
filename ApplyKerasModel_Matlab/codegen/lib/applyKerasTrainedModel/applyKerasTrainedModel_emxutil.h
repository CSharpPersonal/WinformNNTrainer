/*
 * applyKerasTrainedModel_emxutil.h
 *
 * Code generation for function 'applyKerasTrainedModel_emxutil'
 *
 */

#ifndef __APPLYKERASTRAINEDMODEL_EMXUTIL_H__
#define __APPLYKERASTRAINEDMODEL_EMXUTIL_H__

/* Include files */
#include <math.h>
#include <stddef.h>
#include <stdlib.h>
#include <string.h>
#include "rtwtypes.h"
#include "applyKerasTrainedModel_types.h"

/* Function Declarations */
extern void b_emxInit_real_T(emxArray_real_T **pEmxArray, int numDimensions);
extern void emxEnsureCapacity(emxArray__common *emxArray, int oldNumel, int
  elementSize);
extern void emxFree_real_T(emxArray_real_T **pEmxArray);
extern void emxInit_real_T(emxArray_real_T **pEmxArray, int numDimensions);

#endif

/* End of code generation (applyKerasTrainedModel_emxutil.h) */
