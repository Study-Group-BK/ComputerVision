function [Xk] = dft(xn)
       N = length(xn);
       n = 0:1:N-1; % row vector for n
       k = 0:1:N-1; % row vecor for k
       WN = exp(-j*2*pi/N); % Twiddle factor (w)
       nk = n'*k; % creates a N by N matrix of nk values
       WNnk = WN .^ nk; % DFT matrix
       Xk = WNnk*xn; 
 end