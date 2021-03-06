function [test_results,output_suppressor] = applyKerasTrainedModel(test_data,weight,NodesArray)
%--------------------------------------------------------------------------
% [Output] = applyKerasTrainedModel(test_data,net)
%
% applying Keras trained neural network to fit input where:
%   -net: Keras Neural Network Object as numpy array (2 layers)
%   -Input: Testing Input
% 
% based on Keras with Tensorflow, python 3.6, all activation function uses
% sigmoid (copy sigmoid.m together with this file for use elsewhere)
%--------------------------------------------------------------------------

output_suppressor = zeros(1,1);
in_size = length(test_data);
cursor = 1;
Layers = length(NodesArray);
temp = test_data';
temp = sigmoid(reshape(weight(cursor:cursor + in_size*NodesArray(1)-1),NodesArray(1),in_size)*temp+weight(cursor+in_size*NodesArray(1):cursor+in_size*NodesArray(1)+NodesArray(1)-1)');
cursor = cursor + in_size*NodesArray(1);
cursor = cursor + NodesArray(1);
for i = 2:Layers
    temp = sigmoid(reshape(weight(cursor:cursor + NodesArray(i-1)*NodesArray(i)-1),NodesArray(i),NodesArray(i-1))*temp+weight(cursor+ NodesArray(i-1)*NodesArray(i):cursor+ NodesArray(i-1)*NodesArray(i)+NodesArray(i)-1)');
    cursor = cursor + NodesArray(i-1)*NodesArray(i);
    cursor = cursor + NodesArray(i);
end
final_val = sigmoid(weight(cursor:cursor + NodesArray(Layers)-1)*temp+weight(end));
test_results = zeros(1,1);
test_results(1) = final_val(1);

end