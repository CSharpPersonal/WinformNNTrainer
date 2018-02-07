/*
 * _coder_applyKerasTrainedModel_api.h
 *
 * Code generation for function 'applyKerasTrainedModel'
 *
 */

#ifndef ___CODER_APPLYKERASTRAINEDMODEL_API_H__
#define ___CODER_APPLYKERASTRAINEDMODEL_API_H__
/* Include files */
#include <stdlib.h>
#include <string.h>
#include <math.h>

#include "tmwtypes.h"
#include "mex.h"
#include "emlrt.h"

/* Type Definitions */
#ifndef struct_emxArray_real_T
#define struct_emxArray_real_T
struct emxArray_real_T
{
    double *data;
    int *size;
    int allocatedSize;
    int numDimensions;
    boolean_T canFreeData;
};
#endif /*struct_emxArray_real_T*/
#ifndef typedef_emxArray_real_T
#define typedef_emxArray_real_T
typedef struct emxArray_real_T emxArray_real_T;
#endif /*typedef_emxArray_real_T*/

/* Function Declarations */
extern void applyKerasTrainedModel_initialize(emlrtContext *aContext);
extern void applyKerasTrainedModel_terminate(void);
extern void applyKerasTrainedModel_atexit(void);
extern void applyKerasTrainedModel_api(const mxArray *prhs[3], const mxArray *plhs[2]);
extern void applyKerasTrainedModel(emxArray_real_T *test_data, emxArray_real_T *weight, emxArray_real_T *NodesArray, double *test_results, double *output_suppressor);
extern void applyKerasTrainedModel_xil_terminate(void);

#endif
/* End of code generation (_coder_applyKerasTrainedModel_api.h) */
