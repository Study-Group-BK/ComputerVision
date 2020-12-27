function [Xk] = dft(xn)
%   For length N input vector x, the DFT is a length N vector X,
%   with elements
%                    N-1
%      X(k) =       sum  x(n)*exp(-i*2*pi*k*n/N), 0 <= k <= N-1.
%                   n=0
       xn=xn(:); %make sure xn is a column vector
       N = length(xn);
       n = 0:1:N-1; %row vector for n
       k = 0:1:N-1; %row vector for k
       WN = exp(-i*2*pi/N); %Twiddle factor (w)
       nk = n'*k; %creates a N by N matrix of nk values
       WNnk = WN .^ nk; %DFT matrix
       Xk = WNnk*xn; 
 end