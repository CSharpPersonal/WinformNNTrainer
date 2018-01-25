function [test_results] = applyKerasTrainedModel(test_data,weight,Layers,NodesArray)
%--------------------------------------------------------------------------
% [Output] = applyKerasTrainedModel(test_data,net)
%
% applying Keras trained neural network to fit input where:
%   -net: Keras Neural Network Object as numpy array (2 layers)
%   -Input: Testing Input
% 
% based on Keras with Tensorflow, python 3, all activation function uses
% sigmoid (copy sigmoid.m together with this file for use elsewhere)
%--------------------------------------------------------------------------

in_size = length(test_data);
cursor = 1;
net{1,1} = reshape(weight(cursor:cursor + in_size*NodesArray(1)-1),in_size,NodesArray(1));
cursor = cursor + in_size*NodesArray(1);
net{1,2} = weight(cursor:cursor+NodesArray(1)-1);
cursor = cursor + NodesArray(1);
for i = 2:length(Layers)
    net{1,2*i-1} = reshape(weight(cursor:cursor + NodesArray(i-1)*NodesArray(i)-1),NodesArray(i-1),NodesArray(i));
    cursor = cursor + NodesArray(i-1)*NodesArray(i);
    net{1,2*i} = weight(cursor:cursor+NodesArray(i)-1);
    cursor = cursor + NodesArray(i);
end
net{1,2*(length(Layers)+1)-1} = weight(cursor:cursor + NodesArray(length(Layers))-1);
net{1,2*(length(Layers)+1)} = weight(end);

temp = test_data;
for i = 1:length(Layers)+1
    temp = sigmoid(net{1,2*i-1}*temp+net{1,2*i});
end
test_results = temp;

end