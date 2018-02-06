// processBinWrapper.h

#include "applyKerasTrainedModel.h"

#include "applyKerasTrainedModel_emxAPI.h"
#include "applyKerasTrainedModel_initialize.h"
#include "applyKerasTrainedModel_terminate.h"
#include <stdio.h>

#pragma once

using namespace System;

namespace ApplyKerasModule {

	public ref class ApplyKerasModule
	{
		
		public:
		double GetPrediction(array<double>^ test_data, array<double>^ weight, array<double>^ NodesArray)

		{
			//input
			emxArray_real_T *emx_test_data, *emx_weight, *emx_NodesArray;
			pin_ptr<real_T> test_dataptr = &test_data[0];
			emx_test_data = emxCreateWrapper_real_T((real_T*)test_dataptr, 1, test_data->Length);
			pin_ptr<real_T> weightptr = &weight[0];
			emx_weight = emxCreateWrapper_real_T((real_T*)weightptr, 1, weight->Length);
			pin_ptr<real_T> Nodesptr = &test_data[0];
			emx_NodesArray = emxCreateWrapper_real_T((real_T*)test_dataptr, 1, test_data->Length);

			applyKerasTrainedModel_initialize();
			Console::WriteLine("[DEBUG] AKM initialised");
			double result = applyKerasTrainedModel(emx_test_data, emx_weight, emx_NodesArray);
			Console::WriteLine("[DEBUG] AKM terminated");
			applyKerasTrainedModel_terminate();

			emxDestroyArray_real_T(emx_NodesArray);
			emxDestroyArray_real_T(emx_weight);
			emxDestroyArray_real_T(emx_test_data);
			return result;
		}
	};
}